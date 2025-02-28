internal class Program
{
    private static void Main(string[] args)
    {
        GetBoolDataService getBoolDataService = new GetBoolDataService();
        SaleService saleService = new SaleService();
        GetNumericDataService getNumericDataService = new GetNumericDataService();
        GetStringDataService getStringDataService = new GetStringDataService();
        SubSaleService subSaleService = new SubSaleService(getNumericDataService, getStringDataService, saleService);

        OrderService orderService = new OrderService(getBoolDataService, saleService, subSaleService);
        orderService.CanContinue();
    }
}
