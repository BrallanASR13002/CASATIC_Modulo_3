public class SaleService : ISale
{
    List<SubSale> SubSales { get; set; }
    public void CalculateTotal()
    {
        Console.WriteLine("Calculating total sale...");
        foreach (var subSale in SubSales)
        {
            Console.WriteLine($"Subtotal: {subSale.SubTotal}");
        }
        decimal totalSale = SubSales.Sum(subSale => subSale.SubTotal);
    }
}