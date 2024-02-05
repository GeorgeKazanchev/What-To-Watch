import React from 'react';
import PropTypes from 'prop-types';
import MoviesList from '../MoviesList/MoviesList.jsx';
import { CustomPropTypes } from '../../util/custom-prop-types.js';
import { MAX_SIMILAR_MOVIES_COUNT } from '../../util/constants.js';

export default function SimilarMovies({ movies, currentMovie, onSimilarMovieClick }) {
    const similarMovies = getSimilarMovies(movies, currentMovie).slice(0, MAX_SIMILAR_MOVIES_COUNT);

    return (
        <section className='catalog catalog--like-this'>
            <h2 className='catalog__title'>More like this</h2>
            <MoviesList
                movies={similarMovies}
                onMovieClick={onSimilarMovieClick} />
        </section>
    );
}

function getSimilarMovies(movies, currentMovie) {
    const sameGenreMovies = movies.filter((movie) => {
        return haveSameGengres(movie.genres, currentMovie.genres) && movie.id !== currentMovie.id;
    });

    return sameGenreMovies;
}

function haveSameGengres(genres1, genres2) {
    return genres1.some((genre) => genres2.includes(genre));
}

SimilarMovies.propTypes = {
    movies: PropTypes.arrayOf(CustomPropTypes.MOVIE).isRequired,
    currentMovie: CustomPropTypes.MOVIE,
    onSimilarMovieClick: PropTypes.func.isRequired
};