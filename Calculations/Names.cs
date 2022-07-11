namespace Calculations;

public class Names
{
    public string? NickName { get; init; }

    public static string MakeFullName(string firstName, string lastName)
    {
        return $"{firstName} {lastName}";
    }
}