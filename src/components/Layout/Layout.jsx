import React from 'react';
import PropTypes from 'prop-types';
import { MainPageContent } from '../MainPageContent/MainPageContent.jsx';

export function Layout({background, userAvatar, movieInfo, genresList, moviesList}) {
    return (
        <MainPageContent background={background} userAvatar={userAvatar} movieInfo={movieInfo}
            genresList={genresList} moviesList={moviesList}/>
    );
}

Layout.propTypes = {
    background: PropTypes.object,
    userAvatar: PropTypes.object,
    movieInfo: PropTypes.object,
    genresList: PropTypes.array,
    moviesList: PropTypes.array
};