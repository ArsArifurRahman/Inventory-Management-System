﻿namespace Domain.Models;
public partial class Product
{
    public Product()
    {
        ProductStock = new HashSet<ProductStock>();
        SellingAdjustment = new HashSet<SellingAdjustment>();
        PurchaseList = new HashSet<PurchaseList>();
        SellingList = new HashSet<SellingList>();
    }

    public int Id { get; set; }
    public int ProductCatalogId { get; set; }
    public virtual ProductCatalog ProductCatalog { get; set; }
    public string ProductName { get; set; }
    public string Description { get; set; }
    public string Warranty { get; set; }
    public string Note { get; set; }
    public decimal SellingPrice { get; set; }
    public DateTime InsertDate { get; set; }
    public virtual ICollection<ProductStock> ProductStock { get; set; }
    public virtual ICollection<SellingAdjustment> SellingAdjustment { get; set; }
    public virtual ICollection<PurchaseList> PurchaseList { get; set; }
    public virtual ICollection<SellingList> SellingList { get; set; }
}
