import React from 'react';
import MovieReview from './components/MovieReview/MovieReview.jsx';
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

function getMovieReviewColumns(splittedReviews) {
    return splittedReviews.map((reviewColumn, index) => {
        return (
            <div
                key={index}
                className='movie-card__reviews-col'>
                {reviewColumn.map((review) =>
                    <MovieReview
                        key={review.id}
                        review={review} />)}
            </div>
        );
    });
}

MovieReviews.propTypes = {
    reviews: CustomPropTypes.MOVIE_REVIEWS
};