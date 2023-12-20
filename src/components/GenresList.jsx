import React from 'react';
import PropTypes from 'prop-types';
import { Genre } from './Genre.jsx';

export function GenresList({genresList}) {
    const genres = genresList.map((genre) => <Genre name={genre.name} href={genre.href} isActive={genre.isActive}
        key={genre.id}/>);
    
    return (
        <ul className="catalog__genres-list">
            {genres}
        </ul>
    );
}

GenresList.propTypes = {
    genresList: PropTypes.string
};