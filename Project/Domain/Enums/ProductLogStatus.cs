using System.ComponentModel;

namespace Domain.Enums;
public enum ProductLogStatus
{
    [Description("Buy")] Buy,
    [Description("Sale")] Sale,
    [Description("Return")] Return,
    [Description("Product Damaged")] Damaged,
    [Description("Warranty Delivery")] WarrantyDelivery,
    [Description("Purchase Bill Update")] PurchaseUpdate,
    [Description("Warranty Acceptance")] WarrantyAcceptance,
}
