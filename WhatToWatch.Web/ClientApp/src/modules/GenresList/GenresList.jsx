import React from 'react';
import PropTypes from 'prop-types';
import Genre from '../../components/Genre/Genre.jsx';
import { MAX_SHOWN_GENRES } from './constants/maxShownGenres.js';
import { CustomPropTypes } from '../../util/custom-prop-types.js';

export default function GenresList({ genres, activeGenre, onGenreClick }) {
    const shownGenres = genres.slice(0, MAX_SHOWN_GENRES);
    const genresComponents = getGenresComponents(shownGenres, activeGenre, onGenreClick);

    return (
        <ul className='catalog__genres-list'>
            {genresComponents}
        </ul>
    );
}

function getGenresComponents(genres, activeGenre, onGenreClick) {
    return genres.map((genre) =>
        <Genre
            key={genre + '-id'}
            name={genre}
            isActive={genre === activeGenre}
            onGenreClick={(evt) => {
                evt.preventDefault();
                onGenreClick(genre);
            }} />)
}

GenresList.propTypes = {
    genres: PropTypes.arrayOf(CustomPropTypes.GENRE).isRequired,
    activeGenre: PropTypes.string.isRequired,
    onGenreClick: PropTypes.func.isRequired
};