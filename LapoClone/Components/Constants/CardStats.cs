namespace LapoClone.Components.Constants
{
    public class CardStats
    {
        public string CardStatName { get; set; }

        public string CardStat { get; set; }

        public string CardStatImg { get; set; }

        public double? CardStatRating { get; set; } = null;

        public bool RequiresAttention { get; set; } = false;

        public string? CardStatPeriod { get; set; } = null;
    }
}
