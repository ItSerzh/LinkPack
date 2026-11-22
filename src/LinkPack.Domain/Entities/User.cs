using System;
using System.Collections.Generic;
using System.Text;

namespace LinkPack.Domain.Entities;

public class User
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;

    public DateTimeOffset? LastLogIn { get; set; }

    public bool IsActive { get; set; }
}
