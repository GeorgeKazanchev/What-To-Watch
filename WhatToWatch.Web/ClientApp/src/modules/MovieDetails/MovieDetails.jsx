import React from 'react';
import getStarringElements from './helpers/getStarringElements.jsx';
import { CustomPropTypes } from '../../util/custom-prop-types.js';

export default function MovieDetails({ movie }) {
    const directorsLabel = movie.directors.length > 1 ? 'Directors' : 'Director';
    const starringElements = getStarringElements(movie.starring);

    return (
        <React.Fragment>
            <div className='movie-card__text movie-card__row'>
                <div className='movie-card__text-col'>
                    <p className="movie-card__details-item">
                        <strong className='movie-card__details-name'>{directorsLabel}</strong>
                        <span className='movie-card__details-value'>{movie.directors.join(', ')}</span>
                    </p>
                    <p className='movie-card__details-item'>
                        <strong className='movie-card__details-name'>Starring</strong>
                        <span className='movie-card__details-value'>
                            {starringElements}
                        </span>
                    </p>
                </div>
            </div>
            <div className='movie-card__text-col'>
                <p className="movie-card__details-item">
                    <strong className="movie-card__details-name">Run Time</strong>
                    <span className="movie-card__details-value">{movie.runTime}</span>
                </p>
                <p className="movie-card__details-item">
                    <strong className="movie-card__details-name">Genres</strong>
                    <span className="movie-card__details-value">{movie.genres.join(', ')}</span>
                </p>
                <p className="movie-card__details-item">
                    <strong className="movie-card__details-name">Released</strong>
                    <span className="movie-card__details-value">{movie.date}</span>
                </p>
            </div>
        </React.Fragment>
    );
}

MovieDetails.propTypes = {
    movie: CustomPropTypes.MOVIE
};