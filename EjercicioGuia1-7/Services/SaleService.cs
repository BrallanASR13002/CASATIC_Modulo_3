public class SaleService : ISale
{
    private List<SubSale> SubSales { get; set; } = new List<SubSale>();

    public void AddSubSale(decimal subtotal)
    {
        if (subtotal > 0)
        {
            SubSales.Add(new SubSale { SubTotal = subtotal });
        }
    }

    public decimal CalculateTotal()
    {
        if (!SubSales.Any())
        {
            Console.WriteLine("No sales recorded.");
            return 0;
        }

        Console.WriteLine("Calculating total sales...");
        foreach (var subSale in SubSales)
        {
            Console.WriteLine($"Subtotal: $ {subSale.SubTotal}");
        }

        decimal totalSale = SubSales.Sum(subSale => subSale.SubTotal);
        Console.WriteLine($"Total sale: $ {totalSale}");
        return totalSale;
    }
}
