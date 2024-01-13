import React from 'react';
import PropTypes from 'prop-types';

export function Genre({name, href, isActive}) {
    const className = `catalog__genres-item ${isActive ? "catalog__genres-item--active" : ""}`;
    
    return (
        <li className={className}>
            <a href={href} className="catalog__genres-link">{name}</a>
        </li>
    );
}

Genre.propTypes = {
    name: PropTypes.string,
    href: PropTypes.string,
    isActive: PropTypes.bool
};