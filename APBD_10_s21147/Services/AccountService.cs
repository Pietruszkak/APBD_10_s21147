using APBD_10_s21147.Contexts;
using APBD_10_s21147.Exceptions;
using APBD_10_s21147.Models;
using APBD_10_s21147.ResponseModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace APBD_10_s21147.Services;

public interface IAccountService
{
    Task<GetAccountResponseModel> GetAccountByIdAsync(int id, CancellationToken cancellationToken);
}
public class AccountService(DatabaseContext context) : IAccountService
{
    public async Task<GetAccountResponseModel> GetAccountByIdAsync(int id,CancellationToken cancellationToken)
    {
        var shoppingCarts =
            await context.ShoppingCarts.Where(e => e.AccountId == id).Select(e=> new ShoppingCartResponseModel
            {
                ProductId=e.ProductId,
                ProductName= e.Product.Name,
                Amount = e.Amount
            }).ToListAsync(cancellationToken);
        
        var result = await context.Accounts.Include(e=>e.ShoppingCarts)
            .Where(e => e.AccountId == id)
            .Select(e => new GetAccountResponseModel
        {
            FirstName = e.FirstName,
            LastName = e.LastName,
            Email = e.Email,
            Phone = e.Phone,
            Role = e.Role.Name,
            Cart = e.ShoppingCarts.Select(p=> new ShoppingCartResponseModel
            {
                ProductId = p.ProductId,
                ProductName = p.Product.Name,
                Amount=p.Amount
            })
        }).FirstOrDefaultAsync(cancellationToken);
        if (result is null)
        {
            throw new NotFoundException($"Account with id:{id} not found.");
        }

        return result;
    }
}