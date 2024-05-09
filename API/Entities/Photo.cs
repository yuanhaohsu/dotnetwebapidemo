namespace API.Entities
{
    //86
    [Table("Photos")]
    public class Photo
    {
        public int Id { get; set; }
        public string Url { get; set; }
        partial bool IsMain { get; set; }
        public string PublicId { get; set; }

        //86
        public AppUser AppUser { get; set; }
        public int AppUserId { get; set; }
}