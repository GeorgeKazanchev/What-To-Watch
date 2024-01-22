import React, { useEffect } from 'react';
import PropTypes from 'prop-types';

export default function VideoPlayer({sources, poster, isPlaying}) {
    const video = React.useRef(null);
    const sourcesList = sources.map((source) =>
        <source src={source.path} type={source.type}/>);
    const ERROR_MESSAGE = 'Your browser does not support the video tag.';

    useEffect(() => {
        if (isPlaying) {
            video.current.play();
        }
        else {
            video.current.pause();
        }
    });

    return (
        <React.Fragment>
            <video
                width='280'
                height='175'
                poster={poster}
                autoPlay={isPlaying ? 'true' : ''}
                loop='loop'
                muted
                ref={video}>
                {sourcesList}
                {ERROR_MESSAGE}
            </video>
        </React.Fragment>
    );
}

VideoPlayer.PropTypes = {
    sources: PropTypes.array.isRequired,
    poster: PropTypes.string.isRequired,
    isPlaying: PropTypes.bool.isRequired
};