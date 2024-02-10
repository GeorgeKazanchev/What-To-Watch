using System;
using System.Collections.Generic;

namespace WhatToWatch.Data.PostgreSqlAccess.Entities;

public partial class MoviePreview
{
    public int Id { get; set; }

    public int IdMovie { get; set; }

    public string Type { get; set; } = null!;

    public string Source { get; set; } = null!;

    public virtual Movie IdMovieNavigation { get; set; } = null!;
}
