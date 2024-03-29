﻿using System.ComponentModel.DataAnnotations;

namespace Domain.Models;
public partial class ExpenseCategory
{
    public ExpenseCategory()
    {
        Expense = new HashSet<Expense>();
    }

    public int Id { get; set; }

    [Required(ErrorMessage = "Input Category Name!")]
    public string CategoryName { get; set; }

    public virtual ICollection<Expense> Expense { get; set; }
}
