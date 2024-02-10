import React from 'react';

export default function getStarringElements(starring) {
    return starring.map((actor, index) => {
        return (
            <React.Fragment
                key={`${actor}-${index}`}>
                {actor}, <br />
            </React.Fragment>
        );
    })
}