import React from 'react';
import PropTypes from 'prop-types';
import { MovieCardBackground } from './MovieCardBackground.jsx';
import { Header } from './Header.jsx';
import { MovieCardInfo } from './MovieCardInfo.jsx';

export function MovieCard({background, userAvatar, movieInfo}) {
    return (
        <section className="movie-card">
            <MovieCardBackground background={background}/>
            <h1 className="visually-hidden">WTW</h1>
            <Header userAvatar={userAvatar}/>
            <div className="movie-card__wrap">
                <MovieCardInfo movieInfo={movieInfo}/>
            </div>
        </section>
    );
}

MovieCard.propTypes = {
    background: PropTypes.object,
    userAvatar: PropTypes.object,
    movieInfo: PropTypes.object
};