using System.Text.RegularExpressions;

namespace UtmBuilder.Core.ValueObjects.Exception;

public class InvalidUrlException : System.Exception
{

    private const string DefaultMessage = "Invalid URL";
    private const string UrlRegexPattern = @"^((http|ftp|https|www)://)?([\w+?\.\w+])+([a-zA-Z0-9\~\!\@\#\$\%\^\&\*\(\)_\-\=\+\\\/\?\.\:\;\'\,]*)?$";

    public InvalidUrlException(string message = DefaultMessage) 
        : base(message) 
    {
         /// base(message): chama o construtor da classe base (Exception)
    }

    public static void ThrowIfInvalid(string address, string message = DefaultMessage)
    {
        if(string.IsNullOrEmpty(address))
        {
            throw new InvalidUrlException(message);
        }

        if(!Regex.IsMatch(address, UrlRegexPattern))
        {
            throw new InvalidUrlException();
        }
    }
}

