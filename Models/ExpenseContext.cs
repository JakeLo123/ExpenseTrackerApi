using Microsoft.EntityFrameworkCore;

namespace ExpenseTrackerApi.Models;

public class ExpenseContext : DbContext
{
  public ExpenseContext(DbContextOptions<ExpenseContext> options)
    : base(options)
  {
  }

  public DbSet<Expense> Expense { get; set; } = null!;
}