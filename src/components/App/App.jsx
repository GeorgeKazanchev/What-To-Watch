import React from 'react';
import { Layout } from '../Layout/Layout.jsx';
import { background } from '../../debug-data/background.js';
import { userAvatar } from '../../debug-data/user-avatar.js';
import { movieInfo } from '../../debug-data/movie-info.js';
import { genresList } from '../../debug-data/genres-list.js';
import { moviesList } from '../../debug-data/movies-list.js';
import '../../css/main.css';

export default function App() {
    return (
        <Layout background={background} userAvatar={userAvatar} movieInfo={movieInfo}
            genresList={genresList} moviesList={moviesList}/>
    );
}