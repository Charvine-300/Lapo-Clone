using System.ComponentModel.DataAnnotations;

namespace LapoClone.Components.Constants
{
    public class CardFeature
    {
        public required string Icon { get; set; }
        public required string Feature { get; set; }
        public required string Url { get; set; }
    }
}
