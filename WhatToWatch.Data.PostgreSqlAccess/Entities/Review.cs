using System;
using System.Collections.Generic;

namespace WhatToWatch.Data.PostgreSqlAccess.Entities;

public partial class Review
{
    public int Id { get; set; }

    public int IdAuthor { get; set; }

    public string Content { get; set; } = null!;

    public short? Rating { get; set; }

    public DateTime CreationTime { get; set; }

    public int IdMovie { get; set; }

    public virtual User IdAuthorNavigation { get; set; } = null!;

    public virtual Movie IdMovieNavigation { get; set; } = null!;
}
