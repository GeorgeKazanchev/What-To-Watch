import React from 'react';
import { CustomPropTypes } from '../../util/custom-prop-types.js';

export default function MovieReview({ review }) {
    return (
        <React.Fragment>
            <div className='review'>
                <blockquote className='review__quote'>
                    <p className='review__text'>{review.content}</p>
                    <footer className='review__details'>
                        <cite className='review__author'>{review.author}</cite>
                        <time className='review__date' dateTime='2024-01-01'>{review.date}</time>
                    </footer>
                </blockquote>
                <div className='review__rating'>{review.rating}</div>
            </div>
        </React.Fragment>
    );
}

MovieReview.propTypes = {
    review: CustomPropTypes.REVIEW
};