import React from 'react';
import PropTypes from 'prop-types';
import Logo from '../Logo/Logo.jsx';

export default function Footer({ isMainPage }) {
    return (
        <footer className='page-footer'>
            <Logo
                isLight={true}
                isMainPage={isMainPage} />
            <div className='copyright'>
                <p>© 2019 What to watch Ltd.</p>
            </div>
        </footer>
    );
}

Footer.propTypes = {
    isMainPage: PropTypes.bool.isRequired
};