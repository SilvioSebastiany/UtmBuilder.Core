namespace UtmBuilder.Core.ValueObjects
{
    public class Url : ValueObject
    {
        /// <summary>
        /// Address of URL (Website link)
        /// </summary>
        public string Address { get; }

        // set foi removido, porque o endereço de uma URL não deve ser alterado
        // só pode ser definido no construtor

        /// <summary>
        /// Create a new URL
        /// </summary>
        /// <param name="address">Address of URL (Website link)</param>
        public Url(string address)
        {
            Address = address;
        }


    }
}
