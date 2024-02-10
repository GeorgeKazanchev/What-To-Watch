import React from 'react';
import MoviePage from '../MoviePage/MoviePage.jsx';
import NotFound from '../NotFound/NotFound.jsx';
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import { promoMovie, userAvatar, genres, movies } from '../../util/debug-data.js';
import { AppRoute } from './constants/appRoute.js';
import renderApp from './helpers/renderApp.jsx';
import '../../css/main.css';

export default function App() {
    const [currentPage, setCurrentPage] = React.useState(AppRoute.MAIN);
    const [currentMovie, setCurrentMovie] = React.useState(movies[9]);

    const handleMovieClick = (movie) => {
        setCurrentPage(AppRoute.MOVIE);
        setCurrentMovie(movie);
    };

    return (
        <Router>
            <Routes>
                <Route path='/' Component={() => {
                    return renderApp(currentPage, currentMovie, promoMovie, userAvatar,
                        currentMovie.reviews, genres, movies, handleMovieClick);
                }} />
                <Route path='/debug-movie' Component={() =>
                    <MoviePage
                        movie={currentMovie}
                        userAvatar={userAvatar}
                        movies={movies}
                        reviews={currentMovie.reviews}
                        onMovieClick={handleMovieClick} />
                } />
                <Route path='*' Component={
                    () => <NotFound />} />
            </Routes>
        </Router>
    );
}