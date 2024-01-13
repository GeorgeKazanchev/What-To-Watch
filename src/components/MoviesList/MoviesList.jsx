import React from 'react';
import PropTypes from 'prop-types';
import { SmallMovieCard } from '../SmallMovieCard/SmallMovieCard.jsx';

export function MoviesList({moviesList}) {
    const movies = moviesList.map((movie) => <SmallMovieCard poster={movie.poster} title={movie.title} key={movie.id}/>);

    return (
        <div className="catalog__movies-list">
            {movies}
        </div>
    );
}

MoviesList.propTypes = {
    moviesList: PropTypes.array
};