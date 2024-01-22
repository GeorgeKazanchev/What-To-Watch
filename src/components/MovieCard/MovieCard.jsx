import React from 'react';
import PropTypes from 'prop-types';
import { Header } from '../Header/Header.jsx';
import { MovieCardDescription } from '../MovieCardDescription/MovieCardDescription.jsx';

export function MovieCard({movie, userAvatar}) {
    return (
        <section className="movie-card disable-text-selection">
            <div className="movie-card__bg">
                <img src={movie.background} alt={movie.title} />
            </div>
            <h1 className="visually-hidden">WTW</h1>
            <Header userAvatar={userAvatar}/>
            <div className="movie-card__wrap">
                <div className="movie-card__info">
                    <div className="movie-card__poster">
                        <img src={movie.poster} alt={movie.title} width="218" height="327" draggable="false"/>
                    </div>
                    <MovieCardDescription title={movie.title} genres={movie.genres} year={movie.year}/>
                </div>
            </div>
        </section>
    );
}

MovieCard.propTypes = {
    movie: PropTypes.object.isRequired,
    userAvatar: PropTypes.object.isRequired
};