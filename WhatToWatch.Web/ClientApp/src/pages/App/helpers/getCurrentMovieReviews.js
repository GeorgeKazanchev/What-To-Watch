export default function getCurrentMovieReviews(reviews, currentMovie) {
    const currentMovieReviews = reviews.filter((movieReviews) =>
        movieReviews.movie === currentMovie.title);
    return currentMovieReviews[0].reviews;
}