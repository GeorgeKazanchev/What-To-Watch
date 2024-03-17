import React from 'react';
import PropTypes from 'prop-types';
import MovieCardFull from './components/MovieCardFull/MovieCardFull.jsx';
import Footer from '../../components/Footer/Footer.jsx';
import SimilarMovies from '../../modules/SimilarMovies/SimilarMovies.jsx';
import { CustomPropTypes } from '../../util/custom-prop-types.js';
import { NavTabs } from './constants/navTabs.js';

export default function MoviePage({ movie, userAvatar, movies, reviews, onMovieClick }) {
    const [currentTab, setCurrentTab] = React.useState(NavTabs.OVERVIEW);

    const handleTabClick = (tab) => {
        setCurrentTab(tab);
    };

    return (
        <React.Fragment>
            <MovieCardFull
                movie={movie}
                userAvatar={userAvatar}
                reviews={reviews}
                currentTab={currentTab}
                onTabClick={handleTabClick} />
            <div className='page-content'>
                <SimilarMovies
                    movies={movies}
                    currentMovie={movie}
                    onSimilarMovieClick={onMovieClick} />
                <Footer
                    isMainPage={false} />
            </div>
        </React.Fragment>
    );
}

MoviePage.propTypes = {
    movie: CustomPropTypes.MOVIE,
    userAvatar: CustomPropTypes.USER_AVATAR,
    movies: PropTypes.arrayOf(CustomPropTypes.MOVIE).isRequired,
    reviews: PropTypes.arrayOf(CustomPropTypes.REVIEW).isRequired,
    onMovieClick: PropTypes.func.isRequired
};