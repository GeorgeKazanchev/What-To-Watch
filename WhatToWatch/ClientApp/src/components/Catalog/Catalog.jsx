import React from 'react';
import PropTypes from 'prop-types';
import GenresList from '../GenresList/GenresList.jsx';
import MoviesList from '../MoviesList/MoviesList.jsx';

export default function Catalog({genres, movies, onMovieClick}) {
    return (
        <section className="catalog">
            <h2 className="catalog__title visually-hidden">Catalog</h2>
            <GenresList genres={genres} />
            <MoviesList movies={movies} onMovieClick={onMovieClick}/>
            <div className="catalog__more">
                <button className="catalog__button" type="button">Show more</button>
            </div>
        </section>
    );
}

Catalog.propTypes = {
    genres: PropTypes.array.isRequired,
    movies: PropTypes.array.isRequired,
    onMovieClick: PropTypes.func.isRequired
};