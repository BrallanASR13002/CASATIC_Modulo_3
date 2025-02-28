public class SubSaleService : ISubSale
{
    GetDataService getDataService = new GetDataService();
    public decimal CalculateSubTotal()
    {
        Product product = new Product();
        Console.WriteLine("Enter product name: ");
        product.ProductName = getDataService.GetData();
        Console.WriteLine("Enter product description: ");
        product.ProductDescription = getDataService.GetData();
        Console.WriteLine("Enter product amount: ");
        product.ProductAmount = int.Parse(getDataService.GetData());
        Console.WriteLine("Enter product price: ");
        product.ProductPrice = decimal.Parse(getDataService.GetData());
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