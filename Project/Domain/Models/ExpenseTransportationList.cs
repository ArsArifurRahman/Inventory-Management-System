﻿namespace Domain.Models;
public class ExpenseTransportationList
{
    public int Id { get; set; }
    public int ExpenseTransportationId { get; set; }
    public virtual ExpenseTransportation ExpenseTransportation { get; set; }
    public int NumberOfPerson { get; set; }
    public string ExpenseFor { get; set; }
    public string Vehicle { get; set; }
    public decimal ExpenseAmount { get; set; }
}
