import React from 'react';
import { Logo } from './Logo.jsx';

export function Footer() {
    return (
        <footer className="page-footer">
            <Logo isLight={true}/>
            <div className="copyright">
                <p>© 2019 What to watch Ltd.</p>
            </div>
        </footer>
    );
}