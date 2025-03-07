namespace UtmBuilder.Core.ValueObjects
{
    public class Campains : ValueObject
    {
        /// <summary>
        /// Generate a new Campains for a URL
        /// </summary>
        /// <param name="source">The referrer (e.g. google, newsletter)</param>
        /// <param name="medium">Marketing medium (e.g. cpc, banner, email)</param>
        /// <param name="name">Product, promo code, or slogan (e.g. spring_sale)</param>
        /// <param name="id">The ads campaign id</param>
        /// <param name="term">Identify the paid keywords</param>
        /// <param name="content">Use to differentiate similar content, or links within the same ad</param>


        /// <summary>
        /// The referrer (e.g. google, newsletter)
        /// </summary>
        public string Source { get; }

        /// <summary>
        /// Marketing medium (e.g. cpc, banner, email)
        /// </summary>
        public string Medium { get; }

        /// <summary>
        /// Product, promo code, or slogan (e.g. spring_sale)
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// The ads campaign id
        /// </summary>
        public string? Id { get; set; }

        /// <summary>
        /// Identify the paid keywords
        /// </summary>
        public string? Term { get; set; }

        /// <summary>
        /// Use to differentiate similar content, or links within the same ad   
        /// </summary>
        public string? Content { get; set; } 


        public Campains(
            string source, 
            string medium, 
            string name,
            string? id = null,
            string? term = null,
            string? content = null)
        {
            Source = source;
            Medium = medium;
            Name = name;
            Id = id;
            Term = term;
            Content = content;
        }
    }
}