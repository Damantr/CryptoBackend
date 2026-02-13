namespace BackCryptochanger.Models;

public class Exchange
{
    public int Id { get; set; }

    public int? UserId { get; set; }
    public User? User { get; set; }

    public string? RubicRequestId { get; set; }

    public string SrcBlockchain { get; set; } = null!;
    public required Chains SrcBlockchainRef { get; set; } = null!;

    public int? SrcTokenId { get; set; }
    public required Tokens SrcToken { get; set; }

    public decimal SrcAmount { get; set; }

    public string DstBlockchain { get; set; } = null!;
    public required Chains DstBlockchainRef { get; set; } = null!;

    public int? DstTokenId { get; set; }
    public required Tokens DstToken { get; set; }

    public string ReceiverAddress { get; set; } = null!;

    public string? DepositAddress { get; set; }

    public string Status { get; set; } = "pending";

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    public string? TxHashSrc { get; set; }

    public decimal? FinalDstAmount { get; set; }

    public decimal? FeeUsd { get; set; }

    public string? ErrorMessage { get; set; }

    public ICollection<ExchangeStatusHistory> StatusHistory { get; set; } = new List<ExchangeStatusHistory>();

}