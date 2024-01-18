import React from 'react';
import { Main } from '../Main/Main.jsx'; 
import { promoMovie, userAvatar, genres, movies } from '../../debug-data/debug-data.js';
import '../../css/main.css';

export default function App() {
    const handleMovieClick = (evt) => {
        evt.preventDefault();
    };
    
    return (
        <Main 
            promoMovie={promoMovie}
            userAvatar={userAvatar}
            genres={genres}
            movies={movies}
            onMovieClick={handleMovieClick}/>
    );
}