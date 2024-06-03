using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace APBD_10_s21147.Models;

[Table("Products")]
public class Product
{
    [Key]
    [Column("PK_account")]
    public int ProductId { get; set; }
    
    [MaxLength(100)]
    [Column("name")]
    public string Name{ get; set; }
    
    [Precision(18, 2)]
    [Column("weight")]
    public decimal Weight{ get; set; }
    
    [Precision(18, 2)]
    [Column("width")]
    public decimal Width{ get; set; }
    
    [Precision(18, 2)]
    [Column("height")]
    public decimal Height{ get; set; }
    
    //[RegularExpression(@"^\d+(\.\d{1,2})?$")]
    //[Range(0, 999.99)]
    [Precision(18, 2)]
    [Column("depth")]
    public decimal Depth{ get; set; }

    public IEnumerable<ProductCategory> ProductsCategories { get; set; }
}