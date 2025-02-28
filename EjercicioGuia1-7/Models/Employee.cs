public class Employee : IPerson
{
    public string? PersonName { get; set; }
    public string? PersonAddress { get; set; }
    public string? PersonEmail { get; set; }
    public string? PersonPhone { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string? PersonLastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public void ShowInfo()
    {
        throw new NotImplementedException();
    }
}