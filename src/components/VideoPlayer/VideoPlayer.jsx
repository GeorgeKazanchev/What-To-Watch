import React from 'react';
import PropTypes from 'prop-types';

export default function VideoPlayer({sources, poster, isPlaying}) {
    const sourcesList = sources.map((source) =>
        <source src={source.path} type={source.type}/>);
    
    const ERROR_MESSAGE = 'Your browser does not support the video tag.';

    return (
        <video 
            width='280'
            height='175'
            poster={poster}
            autoPlay={isPlaying ? 'true' : ''}
            loop='loop'
            muted>
            {sourcesList}
            {ERROR_MESSAGE}
        </video>
    );
}

VideoPlayer.PropTypes = {
    sources: PropTypes.array.isRequired,
    poster: PropTypes.string.isRequired,
    isPlaying: PropTypes.bool.isRequired
};