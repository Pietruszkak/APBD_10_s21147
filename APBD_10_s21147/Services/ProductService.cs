using APBD_10_s21147.Contexts;
using APBD_10_s21147.Exceptions;
using APBD_10_s21147.Models;
using APBD_10_s21147.ResponseModels;
using Microsoft.EntityFrameworkCore;

namespace APBD_10_s21147.Services;

public interface IProductService
{
    Task<IEnumerable<GetProductsResponseModel>> GetProductsAsync(CancellationToken cancellationToken);
}
public class ProductService(DatabaseContext context) : IProductService
{
    public async Task<IEnumerable<GetProductsResponseModel>> GetProductsAsync(CancellationToken cancellationToken)
    {
        var result = await context.Products.Include(e=>e.ProductsCategories)
            .Select(e => new GetProductsResponseModel
            {
                ProductName = e.Name,
                ProductWeight = e.Weight,
                ProductWidth = e.Width,
                ProductHeight = e.Height,
                ProductDepth = e.Depth,
                ProductCategories = e.ProductsCategories.Select(p=>p.CategoryId).ToList()
            }).ToListAsync(cancellationToken);
        if (result is null)
        {
            throw new NotFoundException($"No Products.");
        }

        return result;
    }
}