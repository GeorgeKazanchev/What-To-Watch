import React from 'react';
import PropTypes from 'prop-types';

export default function MoviePageNavigation({ navTabs, currentTab, onTabClick }) {
    return (
        <nav className='movie-nav movie-card__nav'>
            <ul className='movie-nav__list'>
                {navTabs.map((tab, index) => {
                    return (
                        <li
                            key={index}
                            className={`movie-nav__item ${tab === currentTab ? 'movie-nav__item--active' : ''}`}>
                            <a
                                href='#'
                                className='movie-nav__link'
                                onClick={(evt) => {
                                    evt.preventDefault();
                                    onTabClick(tab);
                                }}>
                                {tab}
                            </a>
                        </li>
                    );
                })}
            </ul>
        </nav>
    );
}

MoviePageNavigation.propTypes = {
    navTabs: PropTypes.arrayOf(PropTypes.string.isRequired).isRequired,
    currentTab: PropTypes.string.isRequired,
    onTabClick: PropTypes.func.isRequired
};