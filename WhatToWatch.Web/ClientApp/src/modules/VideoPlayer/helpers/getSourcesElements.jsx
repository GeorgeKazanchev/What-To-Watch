import React from 'react';

export default function getSourcesElements(sources) {
    return sources.map((source) =>
        <source src={source.path} type={source.type} />);
}