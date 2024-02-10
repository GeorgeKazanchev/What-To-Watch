using WhatToWatch.Domain.Entities;

namespace WhatToWatch.Data.DbAccessInterfaces.Repository
{
    public interface IMoviePreviewRepository
    {
        public List<MoviePreview> ReadMoviePreviews(string movieTitle);
    }
}