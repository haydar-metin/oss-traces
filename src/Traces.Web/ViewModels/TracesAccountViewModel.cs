using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Blazored.Toast.Services;
using Microsoft.AspNetCore.Http;
using Traces.Common;
using Traces.Common.Utils;
using Traces.Web.Models;
using Traces.Web.Services;

namespace Traces.Web.ViewModels
{
    public class TracesAccountViewModel : TracesBaseViewModel
    {
        private readonly ITracesCollectorService _tracesCollectorService;

        public TracesAccountViewModel(
            ITracesCollectorService tracesCollectorService,
            ITraceModifierService traceModifierService,
            IToastService toastService,
            IRequestContext requestContext,
            IHttpContextAccessor httpContextAccessor,
            IApaleoOneService apaleoOneService)
            : base(traceModifierService, toastService, httpContextAccessor, requestContext, apaleoOneService)
        {
            _tracesCollectorService = Check.NotNull(tracesCollectorService, nameof(tracesCollectorService));
        }

        public override async Task LoadNextDaysAsync()
        {
            var loadFromDate = CurrentToDate.AddDays(1);
            var loadUntilDate = CurrentToDate.AddDays(CurrentDayIncrease);

            var tracesResult = await _tracesCollectorService.GetTracesAsync(loadFromDate, loadUntilDate);

            if (tracesResult.Success)
            {
                var traces = tracesResult.Result.ValueOr(new List<TraceItemModel>());

                foreach (var trace in traces)
                {
                    AddTraceToDictionary(trace);
                }

                CurrentToDate = loadUntilDate;

                // After the first run, we always load the next 7 days
                CurrentDayIncrease = 7;

                UpdateLoadedUntilText();
            }
            else
            {
                var errorMessage = tracesResult.ErrorMessage.Match(
                    v => v,
                    () => throw new NotImplementedException());

                ShowToastMessage(false, errorMessage);
            }
        }

        protected override async Task LoadTracesAsync(DateTime from, DateTime to)
        {
            var tracesResult = await _tracesCollectorService.GetTracesAsync(from, to);

            if (tracesResult.Success)
            {
                var traces = tracesResult.Result.ValueOr(new List<TraceItemModel>());

                LoadSortedDictionaryFromList(traces);

                CurrentFromDate = from;
                CurrentToDate = to;
            }
        }

        protected override async Task LoadOverdueTracesAsync()
        {
            var tracesResult = await _tracesCollectorService.GetOverdueTracesAsync();

            if (tracesResult.Success)
            {
                OverdueTraces.Clear();

                var traces = tracesResult.Result.ValueOr(new List<TraceItemModel>());

                foreach (var trace in traces)
                {
                    OverdueTraces.Add(trace);
                }
            }
        }
    }
}