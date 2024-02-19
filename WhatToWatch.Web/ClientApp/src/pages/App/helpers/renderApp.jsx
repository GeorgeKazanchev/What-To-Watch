import React from 'react';
import Main from '../../Main/Main.jsx';
import MoviePage from '../../MoviePage/MoviePage.jsx';
import { AppRoute } from '../constants/appRoute.js';

export default function renderApp(currentPage, currentMovie, promoMovie, userAvatar,
        currentMovieReviews, movies, onMovieClick) {
    switch (currentPage) {
        case AppRoute.MAIN:
            return (
                <Main
                    promoMovie={promoMovie}
                    userAvatar={userAvatar}
                    movies={movies}
                    onMovieClick={onMovieClick} />
            );
        case AppRoute.MOVIE:
            return (
                <MoviePage
                    movie={currentMovie}
                    userAvatar={userAvatar}
                    movies={movies}
                    reviews={currentMovieReviews}
                    onMovieClick={onMovieClick} />
            );
        default:
            return null;
    }
}