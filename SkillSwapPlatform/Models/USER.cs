namespace SkillSwapPlatform2.Models
{
    public class USER
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string ProfilePhotoUrl { get; set; }
        public List<string> SkillsOffered { get; set; }
        public List<string> SkillsWanted { get; set; }
        public double Rating { get; set; }
    }
}
