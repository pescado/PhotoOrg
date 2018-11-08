namespace PhotoOrg.Models
{
    public class PhotoGroup
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool HasEdits { get; set; }
        public bool IsLivePhoto { get; set; }
    }
}