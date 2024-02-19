import React from 'react';
import PropTypes from 'prop-types';
import GenresList from '../GenresList/GenresList.jsx';
import MoviesList from '../MoviesList/MoviesList.jsx';
import { CustomPropTypes } from '../../util/custom-prop-types.js';

export default function Catalog({ genres, movies, onMovieClick }) {
    const [activeGenre, setActiveGenre] = React.useState(genres[0]);

    return (
        <section className='catalog'>
            <h2 className='catalog__title visually-hidden'>Catalog</h2>
            <GenresList genres={genres} activeGenre={activeGenre} onGenreClick={setActiveGenre}/>
            <MoviesList movies={movies} onMovieClick={onMovieClick} />
            <div className='catalog__more'>
                <button className='catalog__button' type='button'>Show more</button>
            </div>
        </section>
    );
}

Catalog.propTypes = {
    genres: PropTypes.arrayOf(CustomPropTypes.GENRE).isRequired,
    movies: PropTypes.arrayOf(CustomPropTypes.MOVIE).isRequired,
    onMovieClick: PropTypes.func.isRequired
};