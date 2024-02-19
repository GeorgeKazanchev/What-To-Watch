import React from 'react';
import PropTypes from 'prop-types';
import getGenresComponents from './helpers/getGenresComponents.jsx';
import { MAX_SHOWN_GENRES } from './constants/maxShownGenres.js';
import { CustomPropTypes } from '../../util/custom-prop-types.js';

export default function GenresList({ genres }) {
    const [activeGenre, setActiveGenre] = React.useState(genres[0]);
    
    genres = genres.slice(0, MAX_SHOWN_GENRES);
    const genresComponents = getGenresComponents(genres, activeGenre, setActiveGenre);
    
    return (
        <ul className='catalog__genres-list'>
            {genresComponents}
        </ul>
    );
}

GenresList.propTypes = {
    genres: PropTypes.arrayOf(CustomPropTypes.GENRE).isRequired
};