using System;
using Microsoft.EntityFrameworkCore;
using Domain;

namespace Persistence;

public class AppDbContext(DbContextOptions options): DbContext(options)
{
    public required DbSet<Activity> Activities { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Activity>(entity =>
        {
            entity.HasKey(a => a.Id);

            entity.Property(a => a.Id);
            entity.Property(a => a.Title);
            entity.Property(a => a.Date);
            entity.Property(a => a.Description);
            entity.Property(a => a.Category);
            entity.Property(a => a.IsCancelled);
            entity.Property(a => a.City);
            entity.Property(a => a.Venue);
            entity.Property(a => a.Latitude);
            entity.Property(a => a.Longitude);

            // No explicit constructor binding needed in EF Core 7+ if names match
        });
    }
}