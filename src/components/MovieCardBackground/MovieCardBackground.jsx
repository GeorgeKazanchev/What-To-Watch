import React from 'react';
import PropTypes from 'prop-types';

export function MovieCardBackground({background}) {
    return (
        <div className="movie-card__bg">
            <img src={background.src} alt={background.desc} />
        </div>
    );
}

MovieCardBackground.propTypes = {
    background: PropTypes.object
};