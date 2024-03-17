export function checkShowMoreEnabled(allMoviesCount, shownMoviesCount) {
    return allMoviesCount === shownMoviesCount ? false : true;
}