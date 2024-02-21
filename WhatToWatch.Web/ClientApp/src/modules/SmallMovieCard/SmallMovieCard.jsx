import React from 'react';
import PropTypes from 'prop-types';
import VideoPlayer from '../VideoPlayer/VideoPlayer.jsx';
import { CustomPropTypes } from '../../util/custom-prop-types.js';

export default function SmallMovieCard({ movie, onMovieClick, onMovieHover, currentMovie }) {
    const [isPlaying, setIsPlaying] = React.useState(false);

    const needToResetVideo = movie.id !== currentMovie?.id;
    const handleMovieClick = (evt) => {
        evt.preventDefault();
        onMovieClick(movie);
        window.scrollTo(0, 0);
    };

    return (
        <article
            className='small-movie-card catalog__movies-card disable-text-selection'
            onMouseOver={() => {
                setIsPlaying(true);
                onMovieHover();
            }}
            onMouseLeave={() => {
                setIsPlaying(false);
            }}>
            <div
                className='small-movie-card__image'
                onClick={handleMovieClick}>
                <VideoPlayer
                    sources={movie.previews}
                    poster={movie.poster}
                    isPlaying={isPlaying}
                    needToResetVideo={needToResetVideo} />
            </div>
            <h3 className='small-movie-card__title' onClick={handleMovieClick}>
                <a href='#' className='small-movie-card__link' draggable='false'>{movie.title}</a>
            </h3>
        </article>
    );
}

SmallMovieCard.propTypes = {
    movie: CustomPropTypes.MOVIE,
    onMovieClick: PropTypes.func.isRequired,
    onMovieHover: PropTypes.func.isRequired
};