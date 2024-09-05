namespace MovieApp.Web.main
{
    public class ListNote : INote
    {

        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<string> TextList { get; set; }

        public string GetContent()
        {
            string result = "Girmiş olduğunuz node:";
            foreach (var item in TextList)
            {
                result+=item;
            }

            return result;
            
        }
    }
}
