import React from 'react';
import PropTypes from 'prop-types';

export function UserBlock({avatar}) {
    return (
        <div className="user-block">
            <div className="user-block__avatar">
                <img src={avatar.src} alt={avatar.description} width="63" height="63" />
            </div>
        </div>
    );
}

UserBlock.propTypes = {
    avatar: PropTypes.object.isRequired
};