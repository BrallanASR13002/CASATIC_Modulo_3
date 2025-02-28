public class GetDataService : IDataInput
{
    public string? DataInputKey { get; set; }
    public string GetData()
    {
        DataInputKey=Console.ReadLine();
        return DataInputKey;
    }
}