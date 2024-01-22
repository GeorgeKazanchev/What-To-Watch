import React from 'react';
import PropTypes from 'prop-types';
import VideoPlayer from '../VideoPlayer/VideoPlayer.jsx';

export default function SmallMovieCard({movie, onMovieClick, onMovieHover}) {
    const [isPlaying, setIsPlaying] = React.useState(false);
    
    const handleMovieClick = (evt) => {
        evt.preventDefault();
        onMovieClick(movie);
        window.scrollTo(0, 0);
    };
    
    return (
        <article
            className='small-movie-card catalog__movies-card disable-text-selection'
            onMouseOver={onMovieHover}>
            <div 
                className='small-movie-card__image'
                onClick={handleMovieClick}>
                <VideoPlayer
                    sources={movie.previews}
                    poster={movie.poster}
                    isPlaying={isPlaying}/>
            </div>
            <h3 className='small-movie-card__title' onClick={handleMovieClick}>
                <a href='#' className='small-movie-card__link' draggable='false'>{movie.title}</a>
            </h3>
        </article>
    );
}

SmallMovieCard.propTypes = {
    poster: PropTypes.string.isRequired,
    title: PropTypes.string.isRequired,
    onMovieClick: PropTypes.func.isRequired,
    onMovieHover: PropTypes.func.isRequired
};