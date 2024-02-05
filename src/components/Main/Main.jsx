import React from 'react';
import PropTypes from 'prop-types';
import MovieCard from '../MovieCard/MovieCard.jsx';
import Catalog from '../Catalog/Catalog.jsx';
import Footer from '../Footer/Footer.jsx';
import { CustomPropTypes } from '../../util/custom-prop-types.js';

export default function Main({ promoMovie, userAvatar, genres, movies, onMovieClick }) {
    return (
        <div className='page-content'>
            <MovieCard
                movie={promoMovie}
                userAvatar={userAvatar}
                isMainPage={true} />
            <Catalog
                genres={genres}
                movies={movies}
                onMovieClick={onMovieClick} />
            <Footer
                isMainPage={true} />
        </div>
    );
}

Main.propTypes = {
    promoMovie: CustomPropTypes.MOVIE,
    userAvatar: CustomPropTypes.USER_AVATAR,
    genres: PropTypes.arrayOf(CustomPropTypes.GENRE).isRequired,
    movies: PropTypes.arrayOf(CustomPropTypes.MOVIE).isRequired,
    onMovieClick: PropTypes.func.isRequired
};