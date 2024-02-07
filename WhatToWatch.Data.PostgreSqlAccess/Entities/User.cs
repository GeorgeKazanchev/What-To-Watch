using System;
using System.Collections.Generic;

namespace WhatToWatch.Data.PostgreSqlAccess.Entities;

public partial class User
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public DateOnly? RegistrationDate { get; set; }

    public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();
}
