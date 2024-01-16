import React from 'react';
import PropTypes from 'prop-types';
import { Catalog } from '../Catalog/Catalog.jsx';
import { Footer } from '../Footer/Footer.jsx';
import { MovieCard } from '../MovieCard/MovieCard.jsx';

export function Main({background, userAvatar, movieInfo, genresList, moviesList}) {
    return (
        <div className="page-content">
            <MovieCard background={background} userAvatar={userAvatar} movieInfo={movieInfo}/>
            <Catalog genresList={genresList} moviesList={moviesList}/>
            <Footer />
        </div>
    );
}

Main.propTypes = {
    background: PropTypes.object,
    userAvatar: PropTypes.object,
    movieInfo: PropTypes.object,
    genresList: PropTypes.array,
    moviesList: PropTypes.array
};