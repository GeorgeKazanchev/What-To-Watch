import React from 'react';
import PropTypes from 'prop-types';
import { MovieCardPoster } from './MovieCardPoster.jsx';
import { MovieCardDescription } from './MovieCardDescription.jsx';

export function MovieCardInfo({movieInfo}) {
    return (
        <div className="movie-card__info">
            <MovieCardPoster poster={movieInfo.poster}/>
            <MovieCardDescription title={movieInfo.title} genre={movieInfo.genre} year={movieInfo.year}/>
        </div>
    );
}

MovieCardInfo.propTypes = {
    movieInfo: PropTypes.object
};