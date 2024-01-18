import React from 'react';
import PropTypes from 'prop-types';

export function SmallMovieCard({poster, title, onMovieClick}) {
    return (
        <article className="small-movie-card catalog__movies-card" onClick={onMovieClick}>
            <div className="small-movie-card__image">
                <img src={poster} alt={title} width="280" height="175" />
            </div>
            <h3 className="small-movie-card__title">
                <a href='#' className="small-movie-card__link">{title}</a>
            </h3>
        </article>
    );
}

SmallMovieCard.propTypes = {
    poster: PropTypes.string.isRequired,
    title: PropTypes.string.isRequired,
    onMovieClick: PropTypes.func.isRequired
};