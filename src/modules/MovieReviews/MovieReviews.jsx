import React from 'react';
import getMovieReviewColumns from './helpers/getMovieReviewColumns.jsx';
import splitReviews from './helpers/splitReviews.js';
import { CustomPropTypes } from '../../util/custom-prop-types.js';

export default function MovieReviews({ reviews }) {
    const splittedReviews = splitReviews(reviews);
    const reviewColumns = getMovieReviewColumns(splittedReviews);

    return (
        <React.Fragment>
            <div className='movie-card__reviews movie-card__row'>
                {reviewColumns}
            </div>
        </React.Fragment>
    );
}

MovieReviews.propTypes = {
    reviews: CustomPropTypes.MOVIE_REVIEWS
};