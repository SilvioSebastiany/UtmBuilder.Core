using System.Text.RegularExpressions;

namespace UtmBuilder.Core.ValueObjects.Exceptions;

public partial class InvalidUrlException : Exception
{

    private const string DefaultErrorMessage = "Invalid URL";

    public InvalidUrlException(string message = DefaultErrorMessage) 
        : base(message) 
    {
         /// base(message): chama o construtor da classe base (Exception)
    }

    public static void ThrowIfInvalid(string address, string message = DefaultErrorMessage)
    {
        if(string.IsNullOrEmpty(address))
        {
            throw new InvalidUrlException(message);
        }

        if(!UrlRegex().IsMatch(address))
        {
            throw new InvalidUrlException();
        }
    }

    [GeneratedRegex("^((http|ftp|https|www)://)?([\\w+?\\.\\w+])+([a-zA-Z0-9\\~\\!\\@\\#\\$\\%\\^\\&\\*\\(\\)_\\-\\=\\+\\\\\\/\\?\\.\\:\\;\\'\\,]*)?$")]
    private static partial Regex UrlRegex();
}

