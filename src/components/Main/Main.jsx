import React from 'react';
import PropTypes from 'prop-types';
import { Catalog } from '../Catalog/Catalog.jsx';
import { Footer } from '../Footer/Footer.jsx';
import { MovieCard } from '../MovieCard/MovieCard.jsx';

export function Main({promoMovie, userAvatar, genres, movies, onMovieClick}) {
    return (
        <div className="page-content">
            <MovieCard movie={promoMovie} userAvatar={userAvatar}/>
            <Catalog genres={genres} movies={movies} onMovieClick={onMovieClick}/>
            <Footer />
        </div>
    );
}

Main.propTypes = {
    promoMovie: PropTypes.object.isRequired,
    userAvatar: PropTypes.object.isRequired,
    genres: PropTypes.array.isRequired,
    movies: PropTypes.array.isRequired,
    onMovieClick: PropTypes.func.isRequired
};