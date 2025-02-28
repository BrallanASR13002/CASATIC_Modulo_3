public class Costumer : ICostumer
{
    public string? PersonName { get; set; }
    public string? PersonAddress { get; set; }
    public string? PersonEmail { get; set; }
    public string? PersonPhone { get; set ; }
    public string? PersonLastName { get; set ; }
    public string? PaymentMethod { get; set; }

    public string? GetPaymentMethod()
    {
        throw new NotImplementedException();
    }

    public void ShowInfo()
    {
        throw new NotImplementedException();
    }
}