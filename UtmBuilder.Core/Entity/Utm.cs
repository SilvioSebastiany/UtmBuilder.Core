using UtmBuilder.Core.Extensions;
using UtmBuilder.Core.ValueObjects;
using UtmBuilder.Core.ValueObjects.Exceptions;

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

        // converte o objeto Utm para string
        // o operador implicit permite que o objeto Utm seja convertido para string automaticamente
        public static implicit operator string(Utm utm) => utm.ToString();

        public static implicit operator Utm(string utmString)
        {
           if(string.IsNullOrEmpty(utmString))
                throw new InvalidUrlException("Invalid URL");

            var url = new Url(utmString);
            var segments = url.Address.Split('?');
            if (segments.Length < 2)
                throw new InvalidUrlException("No segments found in URL");

            var pars = segments[1].Split('&');
            var source = pars.Where(p => p.StartsWith("utm_source")).FirstOrDefault("").Split('=')[1];
            var medium = pars.Where(p => p.StartsWith("utm_medium")).FirstOrDefault("").Split('=')[1];
            var name = pars.Where(p => p.StartsWith("utm_campaign")).FirstOrDefault("").Split('=')[1];
            var id = pars.Where(p => p.StartsWith("utm_id")).FirstOrDefault("").Split('=')[1];
            var term = pars.Where(p => p.StartsWith("utm_term")).FirstOrDefault("").Split('=')[1];
            var content = pars.Where(p => p.StartsWith("utm_content")).FirstOrDefault("").Split('=')[1];

            var utm = new Utm(
                new Url(segments[0]), 
                new Campains(source, medium, name, id, term, content));

            return utm;
            
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
