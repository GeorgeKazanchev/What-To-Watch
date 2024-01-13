import React from 'react';
import PropTypes from 'prop-types';

export function MovieCardPoster({poster}) {
    return (
        <div className="movie-card__poster">
            <img src={poster.src} alt={poster.desc} width="218" height="327" />
        </div>
    );
}

MovieCardPoster.propTypes = {
    poster: PropTypes.object
};