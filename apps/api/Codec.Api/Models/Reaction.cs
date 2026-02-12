namespace Codec.Api.Models;

/// <summary>
/// Represents a single emoji reaction on a message by a user.
/// Each user can react with a given emoji at most once per message.
/// </summary>
public class Reaction
{
    public Guid Id { get; set; }
    public Guid MessageId { get; set; }
    public Guid UserId { get; set; }
    public string Emoji { get; set; } = string.Empty;
    public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;
    public Message? Message { get; set; }
    public User? User { get; set; }
}
