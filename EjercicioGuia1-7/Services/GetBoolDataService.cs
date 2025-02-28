using System.Text.RegularExpressions;
public class GetBoolDataService : IDataInput
{
    public string? DataInputKey { get; set; }
    public string GetData()
    {
        string input;
        do
        {
            Console.Write("Enter only yes/no, true/false, or their equivalents (y/n, s/n): ");
            input = (Console.ReadLine() ?? "").Trim().ToLower();
            Console.Clear();
            if (Regex.IsMatch(input, @"^(true|yes|y|sí|s)$", RegexOptions.IgnoreCase))
            {
                input = "true";
            }
            else if (Regex.IsMatch(input, @"^(false|no|n)$", RegexOptions.IgnoreCase))
            {
                input = "false";
            }
            else
            {
                Console.WriteLine("Invalid entry. Only true/false or their equivalents are allowed.");
                input = "";
            }

        } while (input == "");

        DataInputKey = input;
        return DataInputKey;
    }
}