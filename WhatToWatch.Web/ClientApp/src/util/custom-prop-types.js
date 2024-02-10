import PropTypes from 'prop-types';

export const CustomPropTypes = {
    PREVIEW_SOURCE: PropTypes.shape({
        path: PropTypes.string.isRequired,
        type: PropTypes.string.isRequired
    }).isRequired,

    MOVIE: PropTypes.shape({
        id: PropTypes.string.isRequired,
        title: PropTypes.string.isRequired,
        runTime: PropTypes.string.isRequired,
        genres: PropTypes.arrayOf(PropTypes.string).isRequired,
        year: PropTypes.string.isRequired,
        background: PropTypes.string.isRequired,
        poster: PropTypes.string.isRequired,
        pagePoster: PropTypes.string.isRequired,
        description: PropTypes.string.isRequired,
        rating: PropTypes.string.isRequired,
        ratingDescription: PropTypes.string.isRequired,
        reviewsCount: PropTypes.number.isRequired,
        directors: PropTypes.arrayOf(PropTypes.string).isRequired,
        starring: PropTypes.arrayOf(PropTypes.string).isRequired,
        previews: PropTypes.arrayOf(
            PropTypes.shape({
                path: PropTypes.string.isRequired,
                type: PropTypes.string.isRequired
            }).isRequired
        ).isRequired
    }).isRequired,

    USER_AVATAR: PropTypes.shape({
        src: PropTypes.string.isRequired,
        description: PropTypes.string.isRequired
    }).isRequired,

    GENRE: PropTypes.shape({
        name: PropTypes.string.isRequired
    }).isRequired,

    REVIEW: PropTypes.shape({
        id: PropTypes.string.isRequired,
        author: PropTypes.string.isRequired,
        rating: PropTypes.string.isRequired,
        date: PropTypes.string.isRequired,
        content: PropTypes.string.isRequired
    }).isRequired,

    MOVIE_REVIEWS: PropTypes.shape({
        movie: PropTypes.string.isRequired,
        reviews: PropTypes.arrayOf(
            PropTypes.shape({
                id: PropTypes.string.isRequired,
                author: PropTypes.string.isRequired,
                rating: PropTypes.string.isRequired,
                date: PropTypes.string.isRequired,
                content: PropTypes.string.isRequired
            }).isRequired
        ).isRequired
    }).isRequired
};