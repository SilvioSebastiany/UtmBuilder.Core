namespace UtmBuilder.Core.Extensions
{
    public static class ListExtensions
    {
        public static void AddIfNotNullOrEmpty(this List<string> list, string item)
        {
            // this antes do parâmetro indica que o método é uma extensão de List<string>
            // torna o método AddIfNotNullOrEmpty um método de instância de List<string>

            if (!string.IsNullOrEmpty(item))
            {
                list.Add(item);
            }
        }
    }
}