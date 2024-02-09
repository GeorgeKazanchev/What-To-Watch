import React from 'react';
import Genre from '../../../components/Genre/Genre.jsx';

export default function getGenresComponents(genres) {
    return genres.map((genre) =>
        <Genre
            key={genre.id}
            name={genre.name}
            isActive={false} />)
}