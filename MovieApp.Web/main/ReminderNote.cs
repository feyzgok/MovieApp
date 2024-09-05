
namespace MovieApp.Web.main
{
    public class ReminderNote : INote
    {
        public int Id { get ; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ReminderDate { get; set; }
        public string Text { get; set; }
        public string GetContent()
        {
            if (DateTime.Now >= ReminderDate)
            {
                return $"Expired:{ ReminderDate.ToString()}";
            }

            return $"Girmiş olduğunuz node şudur: {Text}";

        }
    }
}
