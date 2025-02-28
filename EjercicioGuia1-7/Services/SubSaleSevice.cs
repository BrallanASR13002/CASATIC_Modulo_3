public class SubSaleService : ISubSale
{
    GetNumericDataService getNumericDataService = new GetNumericDataService();
    GetStringDataService getStringDataService = new GetStringDataService();
    public decimal CalculateSubTotal()
    {
        Product product = new Product();
        Console.WriteLine("Enter product name: ");
        product.ProductName = getStringDataService.GetData();
        Console.WriteLine("Enter product description: ");
        product.ProductDescription = getStringDataService.GetData();
        Console.WriteLine("Enter product amount: ");
        product.ProductAmount = int.Parse(getNumericDataService.GetData());
        Console.WriteLine("Enter product price: ");
        product.ProductPrice = decimal.Parse(getNumericDataService.GetData());
        SubSale subSale = new SubSale();
        subSale.SubTotal = product.ProductAmount * product.ProductPrice;
        Console.WriteLine($"Product name: {product.ProductName}");
        Console.WriteLine($"Product description: {product.ProductDescription}");
        Console.WriteLine($"Product amount: {product.ProductAmount} ");
        Console.WriteLine($"Product price: {product.ProductPrice} ");
        Console.WriteLine($"Subtotal: {subSale.SubTotal}"
        );
        return subSale.SubTotal;
    }
}