import React from 'react';
import PropTypes from 'prop-types';
import { SmallMovieCard } from '../SmallMovieCard/SmallMovieCard.jsx';

export function MoviesList({movies, onMovieClick}) {
    const moviesList = movies.map((movie) =>
        <SmallMovieCard 
            key={movie.id}
            poster={movie.poster} 
            title={movie.title}
            onMovieClick={onMovieClick}/>);

    return (
        <div className="catalog__movies-list">
            {moviesList}
        </div>
    );
}

MoviesList.propTypes = {
    movies: PropTypes.array.isRequired,
    onMovieClick: PropTypes.func.isRequired
};