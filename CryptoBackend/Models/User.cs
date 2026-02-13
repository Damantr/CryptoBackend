namespace BackCryptochanger.Models;

public class User
{
    public int Id { get; set; }
    public string? WalletAddress { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? LastSeenAt { get; set; }
    public ICollection<Exchange> Exchanges { get; set; } = new List<Exchange>();
}