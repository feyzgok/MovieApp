
namespace MovieApp.Web.main
{
    public class ImgNote : INote
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ImgUrl { get; set; }
        public string Text { get; set; } 

        public string GetContent()
        {
            return $"Image: {ImgUrl}, Text: {Text}";
        }
    }
}
