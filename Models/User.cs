namespace DevPrinciples.Models;

public class User
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }

    // "It's not in the requirements, but one day you might need it ;D"
    public string? AvatarUrl { get; set; }
    public SocialProfile? Social { get; set; }
    public NotificationPreferences? Preferences { get; set; }
}