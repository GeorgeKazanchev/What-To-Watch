import React from 'react';
import PropTypes from 'prop-types';

export function Genre({name, isActive}) {
    const className = `catalog__genres-item ${isActive ? "catalog__genres-item--active" : ""}`;
    
    return (
        <li className={className}>
            <a href='#' className="catalog__genres-link" draggable="false">{name}</a>
        </li>
    );
}

Genre.propTypes = {
    name: PropTypes.string.isRequired,
    isActive: PropTypes.bool.isRequired
};