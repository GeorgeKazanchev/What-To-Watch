import React from 'react';
import PropTypes from 'prop-types';
import SmallMovieCard from '../SmallMovieCard/SmallMovieCard.jsx';
import Header from '../Header/Header.jsx';
import MovieCardButtons from '../MovieCardButtons/MovieCardButtons.jsx';
import MoviePageNavigation from '../MoviePageNavigation/MoviePageNavigation.jsx';
import Footer from '../Footer/Footer.jsx';

export default function MoviePage({ movie, userAvatar, similarMovies, onMovieClick }) {
    const similarMoviesList = similarMovies.map((movie) =>
        <SmallMovieCard 
            key={movie.id}
            movie={movie}
            onMovieClick={onMovieClick}
            onMovieHover={() => {}}/>
    );

    const directorsLabel = movie.directors.length > 1 ? 'Directors' : 'Director'; 

    return (
        <React.Fragment>
            <section className='movie-card movie-card--full'>
                <div className='movie-card__hero'>
                    <div className='movie-card__bg disable-text-selection'>
                        <img src={movie.background} alt={movie.title} draggable='false'/>
                    </div>
                    <h1 className='visually-hidden disable-text-selection'>WTW</h1>
                    <Header userAvatar={userAvatar} />
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
                            <img src={movie.pagePoster} alt={movie.title} width='218' height='327' draggable='false'/>
                        </div>
                        <div className='movie-card__desc'>
                            <MoviePageNavigation />
                            <div className='movie-rating'>
                                <div className='movie-rating__score'>{movie.rating}</div>
                                <p className='movie-rating__meta'>
                                    <span className='movie-rating__level'>{movie.ratingDescription}</span>
                                    <span className='movie-rating__count'>{movie.reviewsCount} reviews</span>
                                </p>
                            </div>
                            <div className='movie-card__text'>
                                <p>{movie.description}</p>
                                <p className='movie-card__director'><strong>{directorsLabel}: {movie.directors.join(', ')}</strong></p>
                                <p className='movie-card__starring'><strong>Starring: {movie.starring.join(', ')}</strong></p>
                            </div>
                        </div>
                    </div>
                </div>
            </section>

            <div className='page-content'>
                <section className='catalog catalog--like-this'>
                    <h2 className='catalog__title'>More like this</h2>
                    <div className='catalog__movies-list'>
                        {similarMoviesList}
                    </div>
                </section>
                <Footer />
            </div>
        </React.Fragment>
    );
}

MoviePage.propTypes = {
    movie: PropTypes.object.isRequired,
    userAvatar: PropTypes.object.isRequired,
    similarMovies: PropTypes.array.isRequired,
    onMovieClick: PropTypes.func.isRequired
};