using UtmBuilder.Core.Extensions;
using UtmBuilder.Core.ValueObjects;

namespace UtmBuilder.Core.Entity
{
    public class Utm
    {
         /// <summary>
        /// URL (Website link) 
        /// </summary>
        public Url Url { get; }

        /// <summary>
        /// Campains Details
        /// </summary>
        public Campains Campains { get; }


        public Utm(Url url, Campains campains)
        {
            Url = url;
            Campains = campains;
        }

        public override string ToString()
        {
            var segments = new List<string>();

            segments.AddIfNotNullOrEmpty("utm_source", Campains.Source);
            segments.AddIfNotNullOrEmpty("utm_medium", Campains.Medium);
            segments.AddIfNotNullOrEmpty("utm_campaign", Campains.Name);
            segments.AddIfNotNullOrEmpty("utm_id", Campains.Id);
            segments.AddIfNotNullOrEmpty("utm_term", Campains.Term);
            segments.AddIfNotNullOrEmpty("utm_content", Campains.Content);
        
            return $"{Url.Address}?{string.Join("&", segments)}";
        }
    }
}
