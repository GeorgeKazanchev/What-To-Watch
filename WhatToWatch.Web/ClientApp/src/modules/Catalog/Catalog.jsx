import React from 'react';
import PropTypes from 'prop-types';
import GenresList from '../GenresList/GenresList.jsx';
import MoviesList from '../MoviesList/MoviesList.jsx';
import ShowMoreMovies from '../ShowMoreMovies/ShowMoreMovies.jsx';
import { CustomPropTypes } from '../../util/custom-prop-types.js';

export default function Catalog({ genres, movies, activeGenre, isShowMoreEnabled, onMovieClick,
        onGenreClick, onShowMoreClick }) {
    return (
        <section className='catalog'>
            <h2 className='catalog__title visually-hidden'>Catalog</h2>
            <GenresList genres={genres} activeGenre={activeGenre} onGenreClick={onGenreClick}/>
            <MoviesList movies={movies} onMovieClick={onMovieClick} />
            <ShowMoreMovies isButtonEnabled={isShowMoreEnabled} onShowMoreClick={onShowMoreClick} />
        </section>
    );
}

Catalog.propTypes = {
    genres: PropTypes.arrayOf(CustomPropTypes.GENRE).isRequired,
    movies: PropTypes.arrayOf(CustomPropTypes.MOVIE).isRequired,
    activeGenre: PropTypes.string.isRequired,
    isShowMoreEnabled: PropTypes.bool.isRequired,
    onMovieClick: PropTypes.func.isRequired,
    onGenreClick: PropTypes.func.isRequired,
    onShowMoreClick: PropTypes.func.isRequired
};