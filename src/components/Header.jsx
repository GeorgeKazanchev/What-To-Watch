import React from 'react';
import PropTypes from 'prop-types';
import { Logo } from './Logo.jsx';
import { UserBlock } from './UserBlock.jsx';

export function Header({userAvatar}) {
    return (
        <header className="page-header movie-card__head">
            <Logo isLight={false}/>
            <UserBlock avatar={userAvatar}/>
        </header>
    );
}

Header.propTypes = {
    userAvatar: PropTypes.object
};