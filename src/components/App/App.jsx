import React from 'react';
import Main from '../Main/Main.jsx'; 
import MoviePage from '../MoviePage/MoviePage.jsx';
import NotFound from '../NotFound/NotFound.jsx';
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import { promoMovie, userAvatar, genres, movies } from '../../util/debug-data.js';
import { AppRoute } from '../../util/settings.js';
import '../../css/main.css';

export default function App() {
    const [currentPage, setCurrentPage] = React.useState(AppRoute.Main);
    const [currentMovie, setCurrentMovie] = React.useState(movies[9]);

    const handleMovieClick = (movie) => {
        setCurrentPage(AppRoute.Movie);
        setCurrentMovie(movie);
    };
    
    const renderApp = () => {
        switch(currentPage) {
            case AppRoute.Main:
                return (
                    <Main 
                        promoMovie={promoMovie}
                        userAvatar={userAvatar}
                        genres={genres}
                        movies={movies}
                        onMovieClick={handleMovieClick}/>
                );
            case AppRoute.Movie:
                return (
                    <MoviePage 
                        movie={currentMovie}
                        userAvatar={userAvatar}
                        movies={movies}
                        onMovieClick={handleMovieClick}/>
                );
            default:
                return null;
        }
    };

    return (
        <Router>
            <Routes>
                <Route path='/' Component={renderApp}/>
                <Route path='/debug-movie' Component={() => 
                    <MoviePage 
                        movie={currentMovie}
                        userAvatar={userAvatar}
                        similarMovies={similarMovies}
                        onMovieClick={handleMovieClick}/>
                }/>
                <Route path='*' Component={
                    () => <NotFound />}/>
            </Routes>
        </Router>
    );
}