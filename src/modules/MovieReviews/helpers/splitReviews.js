export default function splitReviews(reviews) {
    const splitIndex = Math.ceil(reviews.length / 2);
    const firstColumnReviews = reviews.slice(0, splitIndex);
    const secondColumnReviews = reviews.slice(splitIndex, reviews.length);
    return [firstColumnReviews, secondColumnReviews];
}