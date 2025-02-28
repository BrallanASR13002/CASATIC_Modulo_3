public class OrderService: IOrder
{
    public bool ValueEntry { get; set; }

    public bool CanContinue()
    {
        throw new NotImplementedException();
    }
}
