namespace APBD_10_s21147.ResponseModels;

public class GetProductsResponseModel
{
    public string ProductName { get; set; }
    public decimal ProductWeight { get; set; }
    public decimal ProductWidth { get; set; }
    public decimal ProductHeight { get; set; }
    public decimal ProductDepth { get; set; }
    public IEnumerable<int> ProductCategories { get; set; } = [];
}