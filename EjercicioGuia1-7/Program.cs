internal class Program
{
    private static void Main(string[] args)
    {
        //Define the getBoolDataService instance
        GetBoolDataService getBoolDataService = new GetBoolDataService();
        //define the saleService instance
        SaleService saleService = new SaleService();
        //define getNumericDataService instance
        GetNumericDataService getNumericDataService = new GetNumericDataService();
        //define the getStringDataService instance
        GetStringDataService getStringDataService = new GetStringDataService();
        //define the subSaleService instance and use the getNumericDataServic and
        //getStringDataService instance as parameters
        SubSaleService subSaleService = new SubSaleService(getNumericDataService, getStringDataService, saleService);
        //define the orderService instance and use getBoolDataService,   saleService and
        //saleService instance as parameters
        OrderService orderService = new OrderService(getBoolDataService, saleService, subSaleService);
        //calling the Cancontinue method
        orderService.CanContinue();
    }
}
