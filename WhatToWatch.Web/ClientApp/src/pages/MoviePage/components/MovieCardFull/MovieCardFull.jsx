import React from 'react';
import MovieCardHero from '../MovieCardHero/MovieCardHero.jsx';
import MovieCardInfo from '../MovieCardInfo/MovieCardInfo.jsx';

export default function MovieCardFull({ movie, userAvatar, reviews, currentTab, onTabClick }) {
    return (
        <section className='movie-card movie-card--full'>
            <div className="movie-card__bg-wrapper"></div>
            <MovieCardHero
                movie={movie}
                userAvatar={userAvatar} />
            <MovieCardInfo
                movie={movie}
                reviews={reviews}
                currentTab={currentTab}
                onTabClick={onTabClick} />
        </section>
    );
}