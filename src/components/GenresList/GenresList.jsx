import React from 'react';
import PropTypes from 'prop-types';
import Genre from '../Genre/Genre.jsx';

export default function GenresList({genres}) {
    const genresList = genres.map((genre) => 
        <Genre 
            key={genre.id}
            name={genre.name}
            isActive={false}/>);
    
    return (
        <ul className='catalog__genres-list'>
            {genresList}
        </ul>
    );
}

GenresList.propTypes = {
    genres: PropTypes.array.isRequired
};