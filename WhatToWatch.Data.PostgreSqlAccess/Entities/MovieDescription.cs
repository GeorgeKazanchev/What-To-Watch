using System;
using System.Collections.Generic;

namespace WhatToWatch.Data.PostgreSqlAccess.Entities;

public partial class MovieDescription
{
    public int Id { get; set; }

    public int IdMovie { get; set; }

    public string Content { get; set; } = null!;

    public virtual Movie IdMovieNavigation { get; set; } = null!;
}
