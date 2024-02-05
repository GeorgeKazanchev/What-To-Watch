import React from 'react';
import PropTypes from 'prop-types';
import Header from '../Header/Header.jsx';
import MovieCardButtons from '../MovieCardButtons/MovieCardButtons.jsx';
import MoviePageNavigation from '../MoviePageNavigation/MoviePageNavigation.jsx';
import Footer from '../Footer/Footer.jsx';
import SimilarMovies from '../SimilarMovies/SimilarMovies.jsx';
import MovieOverview from '../MovieOverview/MovieOverview.jsx';
import MovieDetails from '../MovieDetails/MovieDetails.jsx';
import MovieReviews from '../MovieReviews/MovieReviews.jsx';
import { CustomPropTypes } from '../../util/custom-prop-types.js';
import { NavTabs } from '../../util/constants.js';

export default function MoviePage({ movie, userAvatar, movies, reviews, onMovieClick }) {
    const [currentTab, setCurrentTab] = React.useState(NavTabs.OVERVIEW);

    const handleTabClick = (tab) => {
        setCurrentTab(tab);
    };

    const renderScreen = () => {
        switch (currentTab) {
            case NavTabs.OVERVIEW:
                return <MovieOverview
                    movie={movie} />;
            case NavTabs.DETAILS:
                return <MovieDetails
                    movie={movie} />;
            case NavTabs.REVIEWS:
                return <MovieReviews
                    reviews={reviews} />;
            default:
                return null;
        }
    };

    return (
        <React.Fragment>
            <section className='movie-card movie-card--full'>
                <div className='movie-card__hero'>
                    <div className='movie-card__bg disable-text-selection'>
                        <img src={movie.background} alt={movie.title} draggable='false' />
                    </div>
                    <h1 className='visually-hidden disable-text-selection'>WTW</h1>
                    <Header
                        userAvatar={userAvatar}
                        isMainPage={false} />
                    <div className='movie-card__wrap'>
                        <div className='movie-card__desc'>
                            <h2 className='movie-card__title'>{movie.title}</h2>
                            <p className='movie-card__meta'>
                                <span className='movie-card__genre'>{movie.genres.join(', ')}</span>
                                <span className='movie-card__year'>{movie.year}</span>
                            </p>
                            <MovieCardButtons />
                        </div>
                    </div>
                </div>

                <div className='movie-card__wrap movie-card__translate-top'>
                    <div className='movie-card__info'>
                        <div className='movie-card__poster movie-card__poster--big'>
                            <img src={movie.pagePoster} alt={movie.title} width='218' height='327' draggable='false' />
                        </div>
                        <div className='movie-card__desc'>
                            <MoviePageNavigation
                                navTabs={Object.values(NavTabs)}
                                currentTab={currentTab}
                                onTabClick={handleTabClick} />
                            {renderScreen()}
                        </div>
                    </div>
                </div>
            </section>

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
    onMovieClick: PropTypes.func.isRequired
};