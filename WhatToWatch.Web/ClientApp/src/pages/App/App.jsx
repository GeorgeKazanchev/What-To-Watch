import React from 'react';
import Main from '../Main/Main.jsx';
import MoviePage from '../MoviePage/MoviePage.jsx';
import NotFound from '../NotFound/NotFound.jsx';
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import { promoMovie, userAvatar, movies } from '../../util/debug-data.js';
import { AppRoute } from './constants/appRoute.js';
import { getSortedMovies } from './helpers/getSortedMovies.js';
import '../../css/main.css';

export default function App() {
    const [currentPage, setCurrentPage] = React.useState(AppRoute.MAIN);
    const [currentMovie, setCurrentMovie] = React.useState(movies[9]);
    
    const sortedMovies = getSortedMovies(movies);

    const handleMovieClick = (movie) => {
        setCurrentPage(AppRoute.MOVIE);
        setCurrentMovie(movie);
    };

    return (
        <Router>
            <Routes>
                <Route path='/' Component={() => {
                    return renderApp(currentPage, currentMovie, promoMovie, userAvatar,
                        currentMovie.reviews, sortedMovies, handleMovieClick);
                }} />
                <Route path='/debug-movie' Component={() =>
                    <MoviePage
                        movie={currentMovie}
                        userAvatar={userAvatar}
                        movies={sortedMovies}
                        reviews={currentMovie.reviews}
                        onMovieClick={handleMovieClick} />
                } />
                <Route path='*' Component={
                    () => <NotFound />} />
            </Routes>
        </Router>
    );
}

function renderApp(currentPage, currentMovie, promoMovie, userAvatar,
    currentMovieReviews, sortedMovies, onMovieClick) {
    switch (currentPage) {
        case AppRoute.MAIN:
            return (
                <Main
                    promoMovie={promoMovie}
                    userAvatar={userAvatar}
                    movies={sortedMovies}
                    onMovieClick={onMovieClick} />
            );
        case AppRoute.MOVIE:
            return (
                <MoviePage
                    movie={currentMovie}
                    userAvatar={userAvatar}
                    movies={sortedMovies}
                    reviews={currentMovieReviews}
                    onMovieClick={onMovieClick} />
            );
        default:
            return null;
    }
}