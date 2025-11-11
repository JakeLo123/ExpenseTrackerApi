namespace ExpenseTrackerApi.Models;

public class Expense
{
    public long Id { get; set; }
    
    /// <summary>
    /// In USD
    /// </summary>
    public required decimal Amount { get; set; }
    
    /// <summary>
    /// To whom the expense was paid.
    /// </summary>
    public required string Vendor { get; set; }
    
    public string Description { get; set; } = "";

    public DateTime CompletedAt { get; set; }

    public Guid UserId { get; set; }

    public User User { get; set; } = null!;
}