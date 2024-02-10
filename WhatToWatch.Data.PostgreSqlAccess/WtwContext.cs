using Microsoft.EntityFrameworkCore;
using WhatToWatch.Data.PostgreSqlAccess.Entities;

namespace WhatToWatch.Data.PostgreSqlAccess;

public partial class WtwContext : DbContext
{
    public WtwContext()
    {
    }

    public WtwContext(string connectionString)
    {
        ConnectionString = connectionString;
        Database.EnsureCreated();
    }

    public WtwContext(DbContextOptions<WtwContext> options)
        : base(options)
    {
    }

    public string ConnectionString { get; }

    public virtual DbSet<Actor> Actors { get; set; }

    public virtual DbSet<Director> Directors { get; set; }

    public virtual DbSet<Genre> Genres { get; set; }

    public virtual DbSet<Movie> Movies { get; set; }

    public virtual DbSet<MovieDescription> MovieDescriptions { get; set; }

    public virtual DbSet<MoviePreview> MoviePreviews { get; set; }

    public virtual DbSet<Review> Reviews { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseNpgsql(ConnectionString);
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Actor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("actor_pkey");

            entity.ToTable("actor");

            entity.HasIndex(e => e.Name, "actor_ukey_name").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Director>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("director_pkey");

            entity.ToTable("director");

            entity.HasIndex(e => e.Name, "director_ukey_name").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Genre>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("genre_pkey");

            entity.ToTable("genre");

            entity.HasIndex(e => e.Name, "movie_uk_name").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Movie>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("movie_pkey");

            entity.ToTable("movie");

            entity.HasIndex(e => e.Title, "movie_ukey_title").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EndYear).HasColumnName("end_year");
            entity.Property(e => e.ReleaseYear).HasColumnName("release_year");
            entity.Property(e => e.Runtime).HasColumnName("runtime");
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .HasColumnName("title");

            entity.HasMany(d => d.IdActors).WithMany(p => p.IdMovies)
                .UsingEntity<Dictionary<string, object>>(
                    "MovieActor",
                    r => r.HasOne<Actor>().WithMany()
                        .HasForeignKey("IdActor")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("movie_actor_fkey_actor"),
                    l => l.HasOne<Movie>().WithMany()
                        .HasForeignKey("IdMovie")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("movie_actor_fkey_movie"),
                    j =>
                    {
                        j.HasKey("IdMovie", "IdActor").HasName("movie_actor_pkey");
                        j.ToTable("movie_actor");
                        j.IndexerProperty<int>("IdMovie").HasColumnName("id_movie");
                        j.IndexerProperty<int>("IdActor").HasColumnName("id_actor");
                    });

            entity.HasMany(d => d.IdDirectors).WithMany(p => p.IdMovies)
                .UsingEntity<Dictionary<string, object>>(
                    "MovieDirector",
                    r => r.HasOne<Director>().WithMany()
                        .HasForeignKey("IdDirector")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("movie_director_fkey_director"),
                    l => l.HasOne<Movie>().WithMany()
                        .HasForeignKey("IdMovie")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("movie_director_fkey_movie"),
                    j =>
                    {
                        j.HasKey("IdMovie", "IdDirector").HasName("movie_director_pkey");
                        j.ToTable("movie_director");
                        j.IndexerProperty<int>("IdMovie").HasColumnName("id_movie");
                        j.IndexerProperty<int>("IdDirector").HasColumnName("id_director");
                    });

            entity.HasMany(d => d.IdGenres).WithMany(p => p.IdMovies)
                .UsingEntity<Dictionary<string, object>>(
                    "MovieGenre",
                    r => r.HasOne<Genre>().WithMany()
                        .HasForeignKey("IdGenre")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("movie_genre_fkey_genre"),
                    l => l.HasOne<Movie>().WithMany()
                        .HasForeignKey("IdMovie")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("movie_genre_fkey_movie"),
                    j =>
                    {
                        j.HasKey("IdMovie", "IdGenre").HasName("movie_genre_pkey");
                        j.ToTable("movie_genre");
                        j.IndexerProperty<int>("IdMovie").HasColumnName("id_movie");
                        j.IndexerProperty<int>("IdGenre").HasColumnName("id_genre");
                    });
        });

        modelBuilder.Entity<MovieDescription>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("movie_description_pkey");

            entity.ToTable("movie_description");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Content)
                .HasMaxLength(1000)
                .HasColumnName("content");
            entity.Property(e => e.IdMovie).HasColumnName("id_movie");

            entity.HasOne(d => d.IdMovieNavigation).WithMany(p => p.MovieDescriptions)
                .HasForeignKey(d => d.IdMovie)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("movie_description_fkey_movie");
        });

        modelBuilder.Entity<MoviePreview>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("movie_preview_pkey");

            entity.ToTable("movie_preview");

            entity.HasIndex(e => new { e.IdMovie, e.Type }, "movie_preview_ukey_movie_and_type").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdMovie).HasColumnName("id_movie");
            entity.Property(e => e.Source)
                .HasMaxLength(100)
                .HasColumnName("source");
            entity.Property(e => e.Type)
                .HasMaxLength(100)
                .HasColumnName("type");

            entity.HasOne(d => d.IdMovieNavigation).WithMany(p => p.MoviePreviews)
                .HasForeignKey(d => d.IdMovie)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("movie_preview_fkey_movie");
        });

        modelBuilder.Entity<Review>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("review_pkey");

            entity.ToTable("review");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Content)
                .HasMaxLength(1000)
                .HasColumnName("content");
            entity.Property(e => e.CreationTime).HasColumnName("creation_time");
            entity.Property(e => e.IdAuthor).HasColumnName("id_author");
            entity.Property(e => e.Rating).HasColumnName("rating");

            entity.HasOne(d => d.IdAuthorNavigation).WithMany(p => p.Reviews)
                .HasForeignKey(d => d.IdAuthor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("review_fkey_author");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("user_pkey");

            entity.ToTable("user");

            entity.HasIndex(e => e.Name, "user_ukey_name").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.RegistrationDate).HasColumnName("registration_date");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
