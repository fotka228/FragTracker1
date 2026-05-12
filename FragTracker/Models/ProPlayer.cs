namespace FragTracker.Models
{
    public class ProPlayer
    {
        public int Id { get; set; }
        public string Nickname { get; set; } = "";
        public string Team { get; set; } = "";
        public string Game { get; set; } = "";
        public int Rating { get; set; }
    }
}
