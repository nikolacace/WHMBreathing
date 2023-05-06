using WHMBreathing.UI.Models.Enums;

namespace WHMBreathing.UI.Models
{
    public class SessionSettings
    {
        public SessionSettings() { }

        public int BreathCount { get; set; }

        public int RetentionTime { get; set; }

        public int RoundsDelay { get; set; }


        public string BackgroundMusic { get; set; }

        public BreathingSpeed BreathingSpeed { get; set; }

        public bool VoicePrompts { get; set; }

        public bool MinutrPrompts { get; set; }

        public bool BreathingSounds { get; set; }
    }
}
