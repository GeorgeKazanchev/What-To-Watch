import React from 'react';
import PropTypes from 'prop-types';

export function SmallMovieCard({movie, onMovieClick, onMovieHover}) {
    const handleMovieClick = (evt) => {
        evt.preventDefault();
        onMovieClick(movie);
        window.scrollTo(0, 0);
    };
    
    return (
        <article
            className="small-movie-card catalog__movies-card disable-text-selection"
            onMouseOver={onMovieHover}
        >
            <div 
                className="small-movie-card__image"
                onClick={handleMovieClick}
            >
                <img src={movie.poster} alt={movie.title} width="280" height="175" />
            </div>
            <h3 className="small-movie-card__title" onClick={handleMovieClick}>
                <a href='#' className="small-movie-card__link" draggable="false">{movie.title}</a>
            </h3>
        </article>
    );
}

SmallMovieCard.propTypes = {
    poster: PropTypes.string.isRequired,
    title: PropTypes.string.isRequired,
    onMovieClick: PropTypes.func.isRequired,
    onMovieHover: PropTypes.func.isRequired
};