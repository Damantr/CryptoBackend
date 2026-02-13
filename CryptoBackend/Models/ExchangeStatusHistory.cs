namespace BackCryptochanger.Models;

public class ExchangeStatusHistory
{
    public int Id { get; set; }
    public int ExchangeId { get; set; }
    public Exchange Exchange { get; set; } = null!;
    public string? OldStatus { get; set; }
    public string NewStatus { get; set; } = null!;
    public string? Details { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}