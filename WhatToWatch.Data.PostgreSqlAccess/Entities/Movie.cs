using System;
using System.Collections.Generic;

namespace WhatToWatch.Data.PostgreSqlAccess.Entities;

public partial class Movie
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public int Runtime { get; set; }

    public short? ReleaseYear { get; set; }

    public short? EndYear { get; set; }

    public virtual ICollection<MovieDescription> MovieDescriptions { get; set; } = new List<MovieDescription>();

    public virtual ICollection<MoviePreview> MoviePreviews { get; set; } = new List<MoviePreview>();

    public virtual ICollection<Actor> IdActors { get; set; } = new List<Actor>();

    public virtual ICollection<Director> IdDirectors { get; set; } = new List<Director>();

    public virtual ICollection<Genre> IdGenres { get; set; } = new List<Genre>();
}
