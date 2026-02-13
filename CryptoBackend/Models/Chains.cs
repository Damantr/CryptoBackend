namespace BackCryptochanger.Models;

public class Chains
{
    public string BlockchainName { get; set; } = null!;
    public string DisplayName { get; set; } = null!;
    
    public string ChainType { get; set; } = null!;

    public bool IsTestnet { get; set; }
    public string? IconUrl { get; set; }

    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? LastSyncAt { get; set; }

    public ICollection<Exchange> SrcExchanges { get; set; } = new List<Exchange>();
    public ICollection<Exchange> DstExchanges { get; set; } = new List<Exchange>();
}