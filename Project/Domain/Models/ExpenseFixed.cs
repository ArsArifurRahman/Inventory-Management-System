﻿namespace Domain.Models;
public class ExpenseFixed
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Amount { get; set; }
    public int IntervalDays { get; set; }
    public decimal CostPerDay { get; set; }
    public DateTime InsertDate { get; set; }
}
