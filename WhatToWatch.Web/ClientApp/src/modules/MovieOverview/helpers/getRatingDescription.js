export default function getRatingDescription(rating) {
    let ratingValue = parseInt(rating);
    if (isNaN(ratingValue)) return '';
    if (ratingValue < 25) return 'Fail';
    else if (ratingValue < 50) return 'Bad';  
    else if (ratingValue < 75) return 'Good';
    else if (ratingValue < 95) return 'Excellent';
    else return 'Masterpiece';
}