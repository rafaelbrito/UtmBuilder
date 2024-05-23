namespace UtmBuilder.Core.Exceptions;

public class InvalidCampaignException : Exception
{
    private const string DefaultErrorMessage = "Invalid UTM parametrs!";

    public InvalidCampaignException(string message = DefaultErrorMessage) : base()
    {
    }

    public static void ThrowIfInvalid(string? item, string message = DefaultErrorMessage)
    {
        if (string.IsNullOrEmpty(item))
            throw new InvalidCampaignException(message);
    }
}