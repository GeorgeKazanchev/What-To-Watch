import React from 'react';
import Header from '../../../../components/Header/Header.jsx';
import MovieCardButtons from '../../../../components/MovieCardButtons/MovieCardButtons.jsx';

export default function MovieCardHero({ movie, userAvatar }) {
    return (
        <div className='movie-card__hero'>
            <div className='movie-card__bg disable-text-selection'>
                <img src={movie.background} alt={movie.title} draggable='false' />
            </div>
            <h1 className='visually-hidden disable-text-selection'>WTW</h1>
            <Header
                userAvatar={userAvatar}
                isMainPage={false} />
            <div className='movie-card__wrap'>
                <div className='movie-card__desc'>
                    <h2 className='movie-card__title'>{movie.title}</h2>
                    <p className='movie-card__meta'>
                        <span className='movie-card__genre'>{movie.genres.join(', ')}</span>
                        <span className='movie-card__year'>{movie.year}</span>
                    </p>
                    <MovieCardButtons />
                </div>
            </div>
        </div>
    );
}