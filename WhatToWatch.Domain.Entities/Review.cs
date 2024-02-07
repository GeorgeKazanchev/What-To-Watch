namespace WhatToWatch.Domain.Entities
{
    public class Review : ICloneable
    {
        public Review(User author, string content, short? rating, DateTime creationTime)
        {
            Author = (User) author.Clone();
            Content = content;
            Rating = rating;
            CreationTime = creationTime;
        }

        public Review(Review review)
        {
            Author = (User) review.Author.Clone();
            Content = review.Content;
            Rating = review.Rating;
            CreationTime = review.CreationTime;
        }

        public User Author { get; }

        public string Content { get; }

        public short? Rating { get; }

        public DateTime CreationTime { get; }

        public object Clone()
        {
            return new Review(this);
        }
    }
}