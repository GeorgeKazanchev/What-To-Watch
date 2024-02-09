import React from 'react';
import PropTypes from 'prop-types';
import getGenresComponents from './helpers/getGenresComponents.jsx';
import { CustomPropTypes } from '../../util/custom-prop-types.js';

export default function GenresList({ genres }) {
    const genresComponents = getGenresComponents(genres);
    
    return (
        <ul className='catalog__genres-list'>
            {genresComponents}
        </ul>
    );
}

GenresList.propTypes = {
    genres: PropTypes.arrayOf(CustomPropTypes.GENRE).isRequired
};