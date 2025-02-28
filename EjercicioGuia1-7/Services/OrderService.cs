public class OrderService : IOrder
{
    private readonly GetBoolDataService _getBoolDataService;
    private readonly SaleService _saleService;
    private readonly SubSaleService _subSaleService;

    public string ValueEntry { get; set; }

    public OrderService(GetBoolDataService getBoolDataService, SaleService saleService, SubSaleService subSaleService)
    {
        _getBoolDataService = getBoolDataService;
        _saleService = saleService;
        _subSaleService = subSaleService;
    }

    public string CanContinue()
    {
        ValueEntry = _getBoolDataService.GetData();
        bool hasSubtotal = false;

        while (ValueEntry != "false")
        {
            decimal subtotal = _subSaleService.CalculateSubTotal();
            if (subtotal > 0)
            {
                hasSubtotal = true;
            }
            ValueEntry = _getBoolDataService.GetData();
        }

        if (hasSubtotal)
        {
            _saleService.CalculateTotal();
        }
        else
        {
            Console.WriteLine("The total was not calculated because there were no subtotals.");
        }

        return ValueEntry;
    }
}
