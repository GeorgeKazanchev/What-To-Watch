import React from 'react';
import PropTypes from 'prop-types';
import { Catalog } from './Catalog.jsx';
import { Footer } from './Footer.jsx';
import { MovieCard } from './MovieCard.jsx';

export function MainPageContent({background, userAvatar, movieInfo, genresList, moviesList}) {
    return (
        <div className="page-content">
            <MovieCard background={background} userAvatar={userAvatar} movieInfo={movieInfo}/>
            <Catalog genresList={genresList} moviesList={moviesList}/>
            <Footer />
        </div>
    );
}

MainPageContent.propTypes = {
    background: PropTypes.object,
    userAvatar: PropTypes.object,
    movieInfo: PropTypes.object,
    genresList: PropTypes.array,
    moviesList: PropTypes.array
};