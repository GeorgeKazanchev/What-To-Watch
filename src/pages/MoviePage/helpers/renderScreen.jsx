import React from 'react';
import MovieOverview from '../../../modules/MovieOverview/MovieOverview.jsx';
import MovieDetails from '../../../modules/MovieDetails/MovieDetails.jsx';
import MovieReviews from '../../../modules/MovieReviews/MovieReviews.jsx';
import { NavTabs } from '../constants/navTabs.js';

export default function renderScreen(currentTab, movie, reviews) {
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