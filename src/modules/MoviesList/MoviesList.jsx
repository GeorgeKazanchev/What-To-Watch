import React from 'react';
import PropTypes from 'prop-types';
import getSmallMovieCards from './helpers/getSmallMovieCards.jsx';
import { CustomPropTypes } from '../../util/custom-prop-types.js';

export default function MoviesList({ movies, onMovieClick }) {
    const [currentMovie, setCurrentMovie] = React.useState(null);
    const smallMovieCards = getSmallMovieCards(movies, onMovieClick, setCurrentMovie);

    return (
        <div className='catalog__movies-list'>
            {smallMovieCards}
        </div>
    );
}

MoviesList.propTypes = {
    movies: PropTypes.arrayOf(CustomPropTypes.MOVIE).isRequired,
    onMovieClick: PropTypes.func.isRequired
};