import React from 'react';
import getRatingDescription from './helpers/getRatingDescription.js';
import { CustomPropTypes } from '../../util/custom-prop-types.js';

export default function MovieOverview({ movie }) {
    const directorsLabel = movie.directors.length > 1 ? 'Directors' : 'Director';

    return (
        <React.Fragment>
            <div className='movie-rating'>
                <div className='movie-rating__score'>{movie.rating}</div>
                <p className='movie-rating__meta'>
                    <span className='movie-rating__level'>{getRatingDescription(movie.rating)}</span>
                    <span className='movie-rating__count'>{movie.reviewsCount} reviews</span>
                </p>
            </div>
            <div className='movie-card__text'>
                <p>{movie.description}</p>
                <p className='movie-card__director'>
                    <strong className='movie-card__director-title'>{directorsLabel}:</strong> {movie.directors.join(', ')}
                </p>
                <p className='movie-card__starring'>
                    <strong className='movie-card__starring-title'>Starring:</strong> {movie.starring.join(', ')}
                </p>
            </div>
        </React.Fragment>
    );
}

MovieOverview.propTypes = {
    movie: CustomPropTypes.MOVIE
};