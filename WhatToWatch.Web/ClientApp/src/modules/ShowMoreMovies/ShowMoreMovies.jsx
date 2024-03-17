import React from 'react';
import PropTypes from 'prop-types';

export default function ShowMoreMovies({ isButtonEnabled, onShowMoreClick }) {
    return (
        <div className='catalog__more'>
            <button
                className='catalog__button'
                type='button'
                disabled={!isButtonEnabled}
                onClick={onShowMoreClick}>
                Show more
            </button>
        </div>
    );
}

ShowMoreMovies.propTypes = {
    isButtonEnabled: PropTypes.bool.isRequired,
    onShowMoreClick: PropTypes.func.isRequired
};