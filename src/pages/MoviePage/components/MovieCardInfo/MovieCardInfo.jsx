import React from 'react';
import MoviePageNavigation from '../MoviePageNavigation/MoviePageNavigation.jsx';
import renderScreen from '../../helpers/renderScreen.jsx';
import { NavTabs } from '../../constants/navTabs.js';

export default function MovieCardInfo({ movie, reviews, currentTab, onTabClick }) {
    return (
        <div className='movie-card__wrap movie-card__translate-top'>
            <div className='movie-card__info'>
                <div className='movie-card__poster movie-card__poster--big'>
                    <img src={movie.pagePoster} alt={movie.title} width='218' height='327' draggable='false' />
                </div>
                <div className='movie-card__desc'>
                    <MoviePageNavigation
                        navTabs={Object.values(NavTabs)}
                        currentTab={currentTab}
                        onTabClick={onTabClick} />
                    {renderScreen(currentTab, movie, reviews)}
                </div>
            </div>
        </div>
    );
}