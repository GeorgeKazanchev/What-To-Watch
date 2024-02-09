import React from 'react';
import MovieReview from '../components/MovieReview/MovieReview.jsx';

export default function getMovieReviewColumns(splittedReviews) {
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