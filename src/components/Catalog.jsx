import React from 'react';
import PropTypes from 'prop-types';
import { GenresList } from './GenresList.jsx';
import { MoviesList } from './MoviesList.jsx';

export function Catalog({genresList, moviesList}) {
    return (
        <section className="catalog">
            <h2 className="catalog__title visually-hidden">Catalog</h2>
            <GenresList genresList={genresList} />
            <MoviesList moviesList={moviesList} />
            <div className="catalog__more">
                <button className="catalog__button" type="button">Show more</button>
            </div>
        </section>
    );
}

Catalog.propTypes = {
    genresList: PropTypes.array,
    moviesList: PropTypes.array
};