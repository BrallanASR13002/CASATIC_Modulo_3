public class SubSaleService : ISubSale
{
    private readonly GetNumericDataService _getNumericDataService;
    private readonly GetStringDataService _getStringDataService;
    private readonly SaleService _saleService;

    public SubSaleService(GetNumericDataService getNumericDataService, GetStringDataService getStringDataService, SaleService saleService)
    {
        _getNumericDataService = getNumericDataService;
        _getStringDataService = getStringDataService;
        _saleService = saleService;
    }

    public decimal CalculateSubTotal()
    {
        Product product = new Product();

        Console.Write("Enter product name: ");
        product.ProductName = _getStringDataService.GetData();

        Console.WriteLine("Enter product description: ");
        product.ProductDescription = _getStringDataService.GetData();

        Console.WriteLine("Enter product amount: ");
        if (!int.TryParse(_getNumericDataService.GetData(), out int amount) || amount <= 0)
        {
            Console.WriteLine("Invalid amount. Please enter a valid number.");
            return 0;
        }
        product.ProductAmount = amount;

        Console.Write("Enter product price: ");
        if (!decimal.TryParse(_getNumericDataService.GetData(), out decimal price) || price <= 0)
        {
            Console.WriteLine("Invalid price. Please enter a valid number.");
            return 0;
        }
        product.ProductPrice = price;

        decimal subTotal = product.ProductAmount * product.ProductPrice;
        _saleService.AddSubSale(subTotal);

        Console.WriteLine($"Registered subtotal: {subTotal}");
        return subTotal;
    }
}
