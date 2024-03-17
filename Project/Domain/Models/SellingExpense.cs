﻿namespace Domain.Models;
public class SellingExpense
{
    public int Id { get; set; }
    public int SellingId { get; set; }
    public Selling Selling { get; set; }
    public decimal Expense { get; set; }
    public string ExpenseDescription { get; set; }
    public DateTime InsertDateUtc { get; set; }
    public int? AccountId { get; set; }
    public Account Account { get; set; }
}
