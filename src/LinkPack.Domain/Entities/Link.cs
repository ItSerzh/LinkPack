namespace LinkPack.Domain.Entities;

public class Link
{
    public int Id { get; set; }

    public string OriginalUrl { get; set; } = null!;

    public string Code { get; set; } = null!;

    public int UserId { get; set; }

    public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;

    public DateTimeOffset? ExpiresAt { get; set; }

    public bool IsActive { get; set; }
}
