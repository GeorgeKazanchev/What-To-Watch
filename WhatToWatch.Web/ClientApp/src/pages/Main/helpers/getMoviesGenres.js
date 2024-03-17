import { ALL_GENRES } from '../constants/constants.js';

export const getMoviesGenres = (movies) => {
    const moviesGenres = [];
    for (let movie of movies) {
        for (let genre of movie.genres) {
            if (!moviesGenres.includes(genre)) {
                moviesGenres.push(genre);
            }
        }
    }
    return [ALL_GENRES, ...moviesGenres];
};