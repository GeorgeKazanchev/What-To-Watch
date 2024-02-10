import React from 'react';
import { CustomPropTypes } from '../../util/custom-prop-types.js';

export default function MovieOverview({ movie }) {
    const directorsLabel = movie.directors.length > 1 ? 'Directors' : 'Director';

    return (
        <React.Fragment>
            <div className='movie-rating'>
                <div className='movie-rating__score'>{movie.rating}</div>
                <p className='movie-rating__meta'>
                    <span className='movie-rating__level'>{movie.ratingDescription}</span>
                    <span className='movie-rating__count'>{movie.reviewsCount} reviews</span>
                </p>
            </div>
            <div className='movie-card__text'>
                <p>{movie.description}</p>
                <p className='movie-card__director'><strong>{directorsLabel}: {movie.directors.join(', ')}</strong></p>
                <p className='movie-card__starring'><strong>Starring: {movie.starring.join(', ')}</strong></p>
            </div>
        </React.Fragment>
    );
}

MovieOverview.propTypes = {
    movie: CustomPropTypes.MOVIE
};