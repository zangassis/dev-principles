namespace DevPrinciples.Utils;

public static class EmailHelper
{
    public static bool Normalize(string? input, out string normalized)
    {
        normalized = string.Empty;

        if (string.IsNullOrWhiteSpace(input) || !input.Contains("@"))
            return false;

        normalized = input.Trim().ToLower();
        return true;
    }
}