import React from 'react';
import PropTypes from 'prop-types';
import MoviesList from '../MoviesList/MoviesList.jsx';

export default function SimilarMovies({movies, currentMovie, onSimilarMovieClick}) {
    return (
        <section className='catalog catalog--like-this'>
            <h2 className='catalog__title'>More like this</h2>
            <MoviesList
                movies={getSimilarMovies(movies, currentMovie)}
                onMovieClick={onSimilarMovieClick}/>
        </section>
    );
}

function getSimilarMovies(movies, currentMovie) {
    const sameGenreMovies = movies.filter((movie) => {
        return haveSameGengres(movie.genres, currentMovie.genres) && movie !== currentMovie;
    });

    return sameGenreMovies.slice(0, MAX_SIMILAR_MOVIES_COUNT);
}

function haveSameGengres(genres1, genres2) {
    return genres1.some((genre) => genres2.includes(genre));
}

export const MAX_SIMILAR_MOVIES_COUNT = 4;

SimilarMovies.propTypes = {
    movies: PropTypes.array.isRequired,
    currentMovie: PropTypes.object.isRequired,
    onSimilarMovieClick: PropTypes.func.isRequired
};