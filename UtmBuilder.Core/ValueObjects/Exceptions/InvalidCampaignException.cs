namespace UtmBuilder.Core.ValueObjects.Exceptions
{
    public partial class InvalidCampaignException : Exception
    {
        private const string DefaultErrorMessage = "Invalid UTM parameters";

        public InvalidCampaignException(string message = DefaultErrorMessage) 
            : base(message) 
        {
            /// base(message): chama o construtor da classe base (Exception)
        }

        public static void ThrowIfInvalid(string item, string message = DefaultErrorMessage)
        {
            if(string.IsNullOrEmpty(item))
            {
                throw new InvalidCampaignException(message);
            }

        }
    }
}