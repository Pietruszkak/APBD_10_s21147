using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace APBD_10_s21147.Models;
[PrimaryKey(nameof(ProductId), nameof(CategoryId))]
[Table("Products_Categories")]
public class ProductCategory
{
    [ForeignKey("Product")]
    public int ProductId { get; set; }
    
    [ForeignKey("Category")]
    public int CategoryId { get; set; }
    
    public Product Product { get; set; }
    public Category Category { get; set; }
}