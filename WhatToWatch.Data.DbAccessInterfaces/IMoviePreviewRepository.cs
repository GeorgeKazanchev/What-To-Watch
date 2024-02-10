using WhatToWatch.Domain.Entities;

namespace WhatToWatch.Data.DbAccessInterfaces
{
    public interface IMoviePreviewRepository
    {
        public List<MoviePreview> ReadMoviePreviews(string movieTitle);
    }
}