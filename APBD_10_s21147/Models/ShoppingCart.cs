using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace APBD_10_s21147.Models;

[PrimaryKey(nameof(AccountId), nameof(ProductId))]
[Table("Shopping_Carts")]
public class ShoppingCart
{
    [ForeignKey("Account")]
    public int AccountId { get; set; }
    
    [ForeignKey("Product")]
    public int ProductId { get; set; }
    
    [Column("amount")]
    public int Amount { get; set; }
    
    public Account Account { get; set; }
    public Product Product { get; set; }
}