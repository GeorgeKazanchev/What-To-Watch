import React from 'react';
import PropTypes from 'prop-types';
import MovieCardButtons from '../MovieCardButtons/MovieCardButtons.jsx';

export default function MovieCardDescription({title, genres, year}) {
    return (
        <div className="movie-card__desc">
            <h2 className="movie-card__title">{title}</h2>
            <p className="movie-card__meta">
                <span className="movie-card__genre">{genres.join(', ')}</span>
                <span className="movie-card__year">{year}</span>
            </p>
            <MovieCardButtons />
        </div>
    );
}

MovieCardDescription.propTypes = {
    title: PropTypes.string.isRequired,
    genre: PropTypes.string.isRequired,
    year: PropTypes.number.isRequired
};