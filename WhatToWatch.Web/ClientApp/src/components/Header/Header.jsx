import React from 'react';
import PropTypes from 'prop-types';
import Logo from '../Logo/Logo.jsx';
import UserBlock from '../UserBlock/UserBlock.jsx';
import { CustomPropTypes } from '../../util/custom-prop-types.js';

export default function Header({ userAvatar, isMainPage }) {
    return (
        <header className='page-header movie-card__head disable-text-selection'>
            <Logo
                isLight={false}
                isMainPage={isMainPage} />
            <UserBlock
                avatar={userAvatar} />
        </header>
    );
}

Header.propTypes = {
    userAvatar: CustomPropTypes.USER_AVATAR,
    isMainPage: PropTypes.bool.isRequired
};