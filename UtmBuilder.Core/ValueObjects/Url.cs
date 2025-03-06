namespace UtmBuilder.Core.ValueObjects
{
    public class Url : ValueObject
    {
        public string Address { get; }

        // set foi removido, porque o endereço de uma URL não deve ser alterado
        // só pode ser definido no construtor

        public Url(string address)
        {
            Address = address;
        }
    }
}
