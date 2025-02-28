using System.Text.RegularExpressions;
public class GetNumericDataService : IDataInput
{
    public string? DataInputKey { get ; set ; }

    public string GetData()
    {
        string input;
        do
        {
            Console.Write("Enter only numbers: ");
            input = Console.ReadLine() ?? "";

            if (!Regex.IsMatch(input, @"^\d+(\.\d+)?$")
)
            {
                Console.WriteLine("Invalid entry. Only numbers allowed.");
            }

        } while (!Regex.IsMatch(input, @"^\d+(\.\d+)?$")
);

        DataInputKey = input;
        return DataInputKey;
    }
}