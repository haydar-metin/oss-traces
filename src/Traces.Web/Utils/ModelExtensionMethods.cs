using Traces.Common.Utils;
using Traces.Core.Models;
using Traces.Core.Models.File;
using Traces.Web.Models;
using Traces.Web.Models.File;

namespace Traces.Web.Utils
{
    public static class ModelExtensionMethods
    {
        public static TraceItemModel ConvertToTraceItemModel(this TraceDto dto)
        {
            Check.NotNull(dto, nameof(dto));

            return new TraceItemModel
            {
                Id = dto.Id,
                Title = dto.Title,
                Description = dto.Description.ValueOr(string.Empty),
                State = dto.State,
                DueDate = dto.DueDate.ToDateTimeUnspecified(),
                PropertyId = dto.PropertyId,
                ReservationId = dto.ReservationId.ValueOr(string.Empty),
                AssignedRole = dto.AssignedRole.ValueOr(string.Empty)
            };
        }

        public static TraceFileItemModel ConvertToTraceFileItemModel(this TraceFileDto dto)
        {
            Check.NotNull(dto, nameof(dto));

            return new TraceFileItemModel
            {
                Id = dto.Id,
                Name = dto.Name,
                Path = dto.Path,
                Size = dto.Size,
                CreatedBy = dto.CreatedBy,
                MimeType = dto.MimeType,
                PublicId = dto.PublicId,
                TraceId = dto.TraceId
            };
        }

        public static SavedFileItemModel ConvertToSavedFileItemModel(this SavedFileDto dto)
        {
            Check.NotNull(dto, nameof(dto));

            return new SavedFileItemModel
            {
                Data = dto.Data,
                TraceFile = dto.TraceFile.ConvertToTraceFileItemModel()
            };
        }
    }
}
