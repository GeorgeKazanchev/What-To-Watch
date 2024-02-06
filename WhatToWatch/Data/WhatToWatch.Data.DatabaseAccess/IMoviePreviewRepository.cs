using WhatToWatch.Domain.Entities;

namespace WhatToWatch.Data.DatabaseAccess
{
    public interface IMoviePreviewRepository
    {
        public List<MoviePreview> ReadMoviePreviews(string movieTitle);
    }
}