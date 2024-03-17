const sortByTitle = (movie1, movie2) => {
    const title1 = movie1.title.toLowerCase();
    const title2 = movie2.title.toLowerCase();

    if (title1 > title2) {
        return 1;
    } else if (title1 < title2) {
        return -1;
    }
    return 0;
};

export const getSortedMovies = (movies) => {
    return movies.sort((movie1, movie2) => sortByTitle(movie1, movie2));
};