namespace LinkPack.Domain.Entities;

public class User
{
    private User() { }

    public int Id { get; private set; }

    public string Name { get; private set; } = null!;

    public string Email { get; private set; } = null!;

    public string PasswordHash { get; private set; } = null!;

    public DateTimeOffset CreatedAt { get; private set; }

    public DateTimeOffset? LastLogIn { get; private set; }

    public bool IsActive { get; private set; }

    public static User Create(string name, string email, string passwordHash)
    {
        return new User
        {
            Name = name,
            Email = email,
            PasswordHash = passwordHash,
            CreatedAt = DateTimeOffset.UtcNow,
            IsActive = true
        };
    }

    public void Deactivate()
    {
        IsActive = false;
    }

    public void RecordLastLogIn()
    {
        LastLogIn = DateTimeOffset.UtcNow;
    }
}
