import React from 'react';
import PropTypes from 'prop-types';

export default function Genre({ name, isActive, onGenreClick }) {
    const className = `catalog__genres-item ${isActive ? 'catalog__genres-item--active' : ''}`;

    return (
        <li className={className} onClick={onGenreClick}>
            <a href='#' className='catalog__genres-link' draggable='false'>{name}</a>
        </li>
    );
}

Genre.propTypes = {
    name: PropTypes.string.isRequired,
    isActive: PropTypes.bool.isRequired,
    onGenreClick: PropTypes.func.isRequired
};