using UtmBuilder.Core.ValueObjects;

namespace UtmBuilder.Core.Entity
{
    public class Utm
    {
        public Url Url { get; set; } = new();
        public Campains Campains { get; set; } = new();
    }
}
