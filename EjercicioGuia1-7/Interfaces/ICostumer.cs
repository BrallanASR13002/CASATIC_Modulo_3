public interface ICostumer: IPerson
{
    string? PaymentMethod { get; set; }
    string? GetPaymentMethod();
}