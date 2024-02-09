import React from 'react';
import SmallMovieCard from '../../SmallMovieCard/SmallMovieCard.jsx';

export default function getSmallMovieCards(movies, onMovieClick, setCurrentMovie) {
    return movies.map((movie) =>
        <SmallMovieCard
            key={movie.id}
            movie={movie}
            onMovieClick={onMovieClick}
            onMovieHover={() => {
                setCurrentMovie(movie);
            }} />);
}