import { ALL_GENRES } from '../constants/constants.js';

export const getMoviesWithGivenGenre = (movies, genre) => {
    if (genre === ALL_GENRES) {
        return movies.slice();
    }
    
    return movies.filter((movie) => movie.genres.includes(genre));
};