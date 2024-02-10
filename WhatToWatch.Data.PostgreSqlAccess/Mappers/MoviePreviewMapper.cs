using PreviewDomain = WhatToWatch.Domain.Entities.MoviePreview;
using PreviewEntity = WhatToWatch.Data.PostgreSqlAccess.Entities.MoviePreview;

namespace WhatToWatch.Data.PostgreSqlAccess.Mappers
{
    public static class MoviePreviewMapper
    {
        public static PreviewDomain ToDomain(PreviewEntity entity)
        {
            var preview = new PreviewDomain(entity.Type, entity.Source);
            return preview;
        }

        public static PreviewEntity ToEntity(PreviewDomain domain)
        {
            var preview = new PreviewEntity
            {
                Type = domain.Type,
                Source = domain.Source
            };
            return preview;
        }
    }
}