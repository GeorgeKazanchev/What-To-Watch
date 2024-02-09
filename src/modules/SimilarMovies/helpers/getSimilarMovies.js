export default function getSimilarMovies(movies, currentMovie) {
    const sameGenreMovies = movies.filter((movie) => {
        return haveSameGengres(movie.genres, currentMovie.genres) && movie.id !== currentMovie.id;
    });

    return sameGenreMovies;
}

function haveSameGengres(genres1, genres2) {
    return genres1.some((genre) => genres2.includes(genre));
}