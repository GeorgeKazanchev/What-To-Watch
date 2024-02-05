import React from 'react';
import MovieReview from '../MovieReview/MovieReview.jsx';
import { CustomPropTypes } from '../../util/custom-prop-types.js';

export default function MovieReviews({ reviews }) {
    const splittedReviews = splitReviews(reviews);

    return (
        <React.Fragment>
            <div className='movie-card__reviews movie-card__row'>
                {splittedReviews.map((reviewsColumn, index) => {
                    return (
                        <div
                            key={index}
                            className='movie-card__reviews-col'>
                            {reviewsColumn.map((review) =>
                                <MovieReview
                                    key={review.id}
                                    review={review} />)}
                        </div>
                    );
                })}
            </div>
        </React.Fragment>
    );
}

function splitReviews(reviews) {
    const splitIndex = Math.ceil(reviews.length / 2);
    const firstColumnReviews = reviews.slice(0, splitIndex);
    const secondColumnReviews = reviews.slice(splitIndex, reviews.length);
    return [firstColumnReviews, secondColumnReviews];
}

MovieReviews.propTypes = {
    reviews: CustomPropTypes.MOVIE_REVIEWS
};