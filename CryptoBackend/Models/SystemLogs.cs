namespace BackCryptochanger.Models;

public class SystemLogs
{
    public int Id { get; set; }

    public string? EventType { get; set; }

    public int? ExchangeId { get; set; }
    public Exchange? Exchange { get; set; }

    // JSONB
    public string? Details { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}