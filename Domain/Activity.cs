using System;

namespace Domain;

public class Activity
{
    public string Id { get; }
    public string Title { get; }
    public DateTime Date { get; }
    public string Description { get; }
    public string Category { get; }
    public bool IsCancelled { get; }
    public string City { get; }
    public string Venue { get; }
    public double Latitude { get; }
    public double Longitude { get; }

    public Activity(
        string id,
        string title,
        DateTime date,
        string description,
        string category,
        bool isCancelled,
        string city,
        string venue,
        double latitude,
        double longitude)
    {
        Id = id;
        Title = title;
        Date = date;
        Description = description;
        Category = category;
        IsCancelled = isCancelled;
        City = city;
        Venue = venue;
        Latitude = latitude;
        Longitude = longitude;
    }
}