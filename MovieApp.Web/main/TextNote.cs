
namespace MovieApp.Web.main
{
    public class TextNote : INote
    {
        public int Id { get ; set; }
        public DateTime CreatedDate { get; set ; }
        public string Text { get; set; }

        public string GetContent()
        {
            return $"Girmiş olduğunuz node şudur: {Text}";
        }


    }
}
