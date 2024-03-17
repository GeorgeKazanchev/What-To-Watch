import React from 'react';
import PropTypes from 'prop-types';
import SmallMovieCard from '../SmallMovieCard/SmallMovieCard.jsx';
import { CustomPropTypes } from '../../util/custom-prop-types.js';

export default function MoviesList({ movies, onMovieClick }) {
    const [currentMovie, setCurrentMovie] = React.useState(null);
    const smallMovieCards = getSmallMovieCards(movies, onMovieClick, currentMovie, setCurrentMovie);

    return (
        <div className='catalog__movies-list'>
            {smallMovieCards}
        </div>
    );
}

function getSmallMovieCards(movies, onMovieClick, currentMovie, setCurrentMovie) {
    return movies.map((movie) =>
        <SmallMovieCard
            key={movie.id}
            movie={movie}
            onMovieClick={onMovieClick}
            onMovieHover={() => {
                setCurrentMovie(movie);
            }}
            currentMovie={currentMovie} />);
}

MoviesList.propTypes = {
    movies: PropTypes.arrayOf(CustomPropTypes.MOVIE).isRequired,
    onMovieClick: PropTypes.func.isRequired
};