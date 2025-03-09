namespace UtmBuilder.Core.ValueObjects.Exception;

public class InvalidUrlException : Exception
{
    public InvalidUrlException(string message = "Invalid URL") 
        : base(message) 
    {
         /// base(message): chama o construtor da classe base (Exception)
    }
}

