namespace Domain.Models;
public class AdminMoneyCollection
{
    public int AdminMoneyCollectionId { get; set; }
    public int RegistrationId { get; set; }
    public Registration Registration { get; set; }
    public decimal CollectionAmount { get; set; }
    public string Description { get; set; }
    public DateTime InsertDateUtc { get; set; }
}
