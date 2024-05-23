using System.Text.RegularExpressions;

namespace UtmBuilder.Core.Exceptions;

public partial class InvalidUrlException : Exception
{
    private const string UrlRegexPattern =
        @"[(http(s)?):\/\/(www\.)?a-zA-Z0-9@:%._\+~#=]{2,256}\.[a-z]{2,6}\b([-a-zA-Z0-9@:%_\+.~#?&//=]*)";

    private const string DefaultErrorMessage = "Invalid URL!";

    public InvalidUrlException(string message = DefaultErrorMessage) : base()
    {
    }

    public static void ThrowIfInvalid(string address, string message = DefaultErrorMessage)
    {
        if (string.IsNullOrEmpty(address))
            throw new InvalidUrlException(message);
        if (!UrlRegex().IsMatch(address))
            throw new InvalidUrlException(message);
    }

    [GeneratedRegex(UrlRegexPattern)]
    private static partial Regex UrlRegex();
}