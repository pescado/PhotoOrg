namespace PhotoOrg.Models
{
    public class PhotoFile
    {
        public long Id { get; set; }
        public string FileExtension { get; set; }
        public bool Rename { get; set; }
        public string Name { get; set; }
    }
}