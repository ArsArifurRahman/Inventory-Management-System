﻿namespace Domain.Models;
public class ProductDamaged
{
    public int Id { get; set; }
    public int ProductStockId { get; set; }
    public ProductStock ProductStock { get; set; }
    public string Note { get; set; }
    public DateTime DamagedDate { get; set; }
    public DateTime InsertDateUtc { get; set; }
}
