import React from 'react';
import PropTypes from 'prop-types';

export default function UserBlock({ avatar }) {
    return (
        <div className='user-block'>
            <div className='user-block__avatar'>
                <a href='#' className='user-block__link'>
                    <img src={avatar.src} alt={avatar.description} width='63' height='63' draggable='false' />
                </a>
            </div>
        </div>
    );
}

UserBlock.propTypes = {
    avatar: PropTypes.object.isRequired
};