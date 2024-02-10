import { movies } from "./debug-data.js";

export const reviews = movies.map((movie) => {
    return (
        {
            movie: `${movie.title}`,
            reviews: [
                {
                    id: 'f07cb619-1aee-472a-bb4d-32dcb094884d',
                    author: 'iliasalk',
                    rating: '30',
                    date: '21 December 2018',
                    content: 'A totally dysfunctional and unrelated cast, an incomprehensible story and ' +
                    'tons and tons of computer graphics. The result is a confusing and totally boring movie. ' +
                    'A waste of money.'
                },
                {
                    id: 'ee504b93-2e3d-42aa-8e59-d51ca798ac9e',
                    author: 'Prismark10',
                    rating: '50',
                    date: '22 November 2018',
                    content: 'Fantastic Beasts: The Crimes of Grindelwald shows that J K Rowling should not ' +
                    'be writing screenplays although I am sure Steve Kloves who is credited as Executive Producer ' + 
                    'had a hand in the script. It is also evident that the directorial duties needs a new vision. ' +
                    'David Yates has been too long in the Potter world.'
                },
                {
                    id: '16e34c22-d938-43a4-88b1-78fc24186466',
                    author: 'carmelarcher_01',
                    rating: '40',
                    date: '31 December 2018',
                    content: 'Almost impossible to keep up with what was going on! Just jumped from one thing to ' +
                    'the next with no development, such a shame'
                },
                {
                    id: '5fa531dd-0f95-427c-a332-f9ba4f8bbe01',
                    author: 'ThomasDrufke',
                    rating: '23',
                    date: '8 December 2018',
                    content: 'I generally hate writing a review about a movie/tv episode that I hate. It feels ' + 
                    'like a waste of energy, especially knowing that there are plenty of people out there who ' + 
                    'genuinely enjoy this film series, but I\'m just not one of them. I LOVE the Harry Potter ' +
                    'movies and grew up with those 8 films, but I\'ve never felt the connection to the Fantastic ' +
                    'Beasts series that I did to Potter.'
                }
            ]
        }
    );
});