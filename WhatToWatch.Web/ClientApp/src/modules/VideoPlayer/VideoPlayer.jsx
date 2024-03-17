import React, { useEffect } from 'react';
import PropTypes from 'prop-types';
import { CustomPropTypes } from '../../util/custom-prop-types.js';
import { VIDEO_NOT_EXIST_ERROR_MESSAGE } from './constants/errorMessage.js';

export default function VideoPlayer({ sources, poster, isPlaying, needToResetVideo }) {
    const video = React.useRef(null);
    const sourcesList = getSourcesElements(sources);

    useEffect(() => {
        if (isPlaying) {
            video.current.play();
        } else {
            if (needToResetVideo) {
                video.current.load();
            } else {
                video.current.pause();
            }
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
                {VIDEO_NOT_EXIST_ERROR_MESSAGE}
            </video>
        </React.Fragment>
    );
}

function getSourcesElements(sources) {
    return sources.map((source, index) =>
        <source
            key={index}
            src={source.path}
            type={source.type} />);
}

VideoPlayer.PropTypes = {
    sources: PropTypes.arrayOf(CustomPropTypes.PREVIEW_SOURCE).isRequired,
    poster: PropTypes.string.isRequired,
    isPlaying: PropTypes.bool.isRequired,
    needToResetVideo: PropTypes.bool.isRequired
};