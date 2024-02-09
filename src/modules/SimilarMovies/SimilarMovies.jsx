import React from 'react';
import PropTypes from 'prop-types';
import MoviesList from '../../modules/MoviesList/MoviesList.jsx';
import getSimilarMovies from './helpers/getSimilarMovies.js';
import { CustomPropTypes } from '../../util/custom-prop-types.js';
import { MAX_SIMILAR_MOVIES_COUNT } from './constants/maxMoviesCount.js';

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

SimilarMovies.propTypes = {
    movies: PropTypes.arrayOf(CustomPropTypes.MOVIE).isRequired,
    currentMovie: CustomPropTypes.MOVIE,
    onSimilarMovieClick: PropTypes.func.isRequired
};