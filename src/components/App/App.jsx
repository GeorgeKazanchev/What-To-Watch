import React from 'react';
import { Main } from '../Main/Main.jsx'; 
import { background, userAvatar, movieInfo, genresList, moviesList } from '../../debug-data/debug-data.js';
import '../../css/main.css';

export default function App() {
    return (
        <Main background={background} userAvatar={userAvatar} movieInfo={movieInfo}
            genresList={genresList} moviesList={moviesList}/>
    );
}