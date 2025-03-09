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

            //segments.AddIfNotNullOrEmpty();
        
            return $"{Url.Address}?{string.Join("&", segments)}";
        }
    }
}
