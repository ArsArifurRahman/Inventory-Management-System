namespace Domain.Models;
public partial class PurchasePaymentList
{
    public int Id { get; set; }
    public int PurchasePaymentId { get; set; }
    public int PurchaseId { get; set; }
    public decimal PurchasePaidAmount { get; set; }
    public DateTime InsertDate { get; set; }
    public virtual Purchase Purchase { get; set; }
    public virtual PurchasePayment PurchasePayment { get; set; }
}
