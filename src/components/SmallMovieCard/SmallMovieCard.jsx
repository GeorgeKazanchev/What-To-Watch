import React from 'react';
import PropTypes from 'prop-types';

export function SmallMovieCard({poster, title}) {
    return (
        <article className="small-movie-card catalog__movies-card">
            <div className="small-movie-card__image">
                <img src={poster.src} alt={poster.desc} width="280" height="175" />
            </div>
            <h3 className="small-movie-card__title">
                <a className="small-movie-card__link" href={title.href}>{title.text}</a>
            </h3>
        </article>
    );
}

SmallMovieCard.propTypes = {
    poster: PropTypes.object,
    title: PropTypes.object
};