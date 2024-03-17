using System.ComponentModel.DataAnnotations;

namespace Domain.Models;
public partial class ProductCatalogType
{
    public ProductCatalogType()
    {
        ProductCatalog = new HashSet<ProductCatalog>();
    }

    public int Id { get; set; }
    [Required]
    public string CatalogType { get; set; }
    public DateTime InsertDate { get; set; }
    public virtual ICollection<ProductCatalog> ProductCatalog { get; set; }
}
