import React from 'react';
import Genre from '../../../components/Genre/Genre.jsx';

export default function getGenresComponents(genres, activeGenre, onGenreClick) {
    return genres.map((genre) =>
        <Genre
            key={genre.id}
            name={genre.name}
            isActive={genre.id === activeGenre.id} 
            onGenreClick={() => {
                onGenreClick(genre);
            }} />)
}