using System.Linq.Expressions;

namespace BackCryptochanger.Models;

public class Tokens
{
    public Guid TokenId { get; set; }
    public required string Type { get; set; }
    public required string BlockChainName { get; set; }
    public decimal MinAmount { get; set; }
    public decimal MaxAmount { get; set; }
    public string? TokenAddress{ get; set; }
    public bool IsNative {get; set;}
    public DateTime UpdatedAt { get; set; }
}