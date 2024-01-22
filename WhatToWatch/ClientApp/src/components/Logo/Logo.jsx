import React from 'react';
import PropTypes from 'prop-types';

export default function Logo({isLight}) {
    const className = `logo__link ${isLight ? "logo__link--light" : ""}`;
    
    return (
        <div className="logo">
            <a className={className}>
                <span className="logo__letter logo__letter--1">W</span>
                <span className="logo__letter logo__letter--2">T</span>
                <span className="logo__letter logo__letter--3">W</span>
            </a>
        </div>
    );
}

Logo.propTypes = {
    isLight: PropTypes.bool.isRequired
};