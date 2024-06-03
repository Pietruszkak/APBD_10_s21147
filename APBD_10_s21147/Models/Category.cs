using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APBD_10_s21147.Models;

[Table("Categories")]
public class Category
{
    [Key]
    [Column("PK_category")]
    public int CategoryId { get; set; }
    
    [MaxLength(100)]
    [Column("name")]
    public string Name{ get; set; }
    
    public IEnumerable<ProductCategory> ProductsCategories { get; set; }
}