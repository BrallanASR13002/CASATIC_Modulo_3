public class OrderService : IOrder
{
    GetBoolDataService getBoolDataService = new GetBoolDataService();
    SaleService saleService = new SaleService();
    public string ValueEntry { get; set; }
    public string CanContinue()
    {
        ValueEntry = getBoolDataService.GetData();
        do
        {
            SubSaleService subSaleService = new SubSaleService();
            subSaleService.CalculateSubTotal();
            ValueEntry = getBoolDataService.GetData();
            saleService.CalculateTotal();
        } while (ValueEntry != "false");
        saleService.CalculateTotal();
        return ValueEntry;
    }
}
