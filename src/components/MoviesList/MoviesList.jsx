import React from 'react';
import PropTypes from 'prop-types';
import SmallMovieCard from '../SmallMovieCard/SmallMovieCard.jsx';
import { CustomPropTypes } from '../../util/custom-prop-types.js';

export default function MoviesList({ movies, onMovieClick }) {
    const [currentMovie, setCurrentMovie] = React.useState(null);

    const moviesList = movies.map((movie) =>
        <SmallMovieCard
            key={movie.id}
            movie={movie}
            onMovieClick={onMovieClick}
            onMovieHover={() => {
                setCurrentMovie(movie);
            }} />);

    return (
        <div className='catalog__movies-list'>
            {moviesList}
        </div>
    );
}

MoviesList.propTypes = {
    movies: PropTypes.arrayOf(CustomPropTypes.MOVIE).isRequired,
    onMovieClick: PropTypes.func.isRequired
};