import React from 'react';
import PropTypes from 'prop-types';
import MovieCard from '../../modules/MovieCard/MovieCard.jsx';
import Catalog from '../../modules/Catalog/Catalog.jsx';
import Footer from '../../components/Footer/Footer.jsx';
import { CustomPropTypes } from '../../util/custom-prop-types.js';
import { ALL_GENRES, MOVIES_SAMPLE_SIZE } from './constants/constants.js';
import { getMoviesGenres } from './helpers/getMoviesGenres.js';
import { getShownMovies } from './helpers/getShownMovies.js';
import { getMoviesWithGivenGenre } from './helpers/getMoviesWithGivenGenre.js';
import { checkShowMoreEnabled } from './helpers/checkShowMoreEnabled.js';

export default function Main({ promoMovie, userAvatar, movies, onMovieClick }) {
    const [shownMoviesCount, setShownMoviesCount] = React.useState(MOVIES_SAMPLE_SIZE);
    const [activeGenre, setActiveGenre] = React.useState(ALL_GENRES);

    const activeGenreMovies = getMoviesWithGivenGenre(movies, activeGenre);
    const shownMovies = getShownMovies(activeGenreMovies, shownMoviesCount);
    const genres = getMoviesGenres(movies);
    const isShowMoreEnabled = checkShowMoreEnabled(activeGenreMovies.length, shownMovies.length);

    const handleGenreClick = (genre) => {
        setShownMoviesCount(MOVIES_SAMPLE_SIZE);
        setActiveGenre(genre);
    }

    const handleShowMoreClick = () => {
        setShownMoviesCount((currentMoviesCount) => currentMoviesCount + MOVIES_SAMPLE_SIZE);
    };

    return (
        <div className='page-content'>
            <MovieCard
                movie={promoMovie}
                userAvatar={userAvatar}
                isMainPage={true} />
            <Catalog
                genres={genres}
                movies={shownMovies}
                activeGenre={activeGenre}
                isShowMoreEnabled={isShowMoreEnabled}
                onMovieClick={onMovieClick}
                onGenreClick={handleGenreClick}
                onShowMoreClick={handleShowMoreClick} />
            <Footer
                isMainPage={true} />
        </div>
    );
}

Main.propTypes = {
    promoMovie: CustomPropTypes.MOVIE,
    userAvatar: CustomPropTypes.USER_AVATAR,
    movies: PropTypes.arrayOf(CustomPropTypes.MOVIE).isRequired,
    onMovieClick: PropTypes.func.isRequired
};