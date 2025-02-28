using System.Text.RegularExpressions;
public class GetStringDataService : IDataInput
{
    public string? DataInputKey { get; set; }

    public string GetData()
    {
        string input;
        do
        {
            Console.Write("Enter only letters: ");
            input = Console.ReadLine() ?? "";

            if (!Regex.IsMatch(input, @"^[a-zA-Z]+( [a-zA-Z]+)*$"))
            {
                Console.WriteLine("Invalid entry. Only letters are allowed.");
            }

        } while (!Regex.IsMatch(input, @"^[a-zA-Z]+( [a-zA-Z]+)*$"));

        DataInputKey = input;
        return DataInputKey;
    }
}