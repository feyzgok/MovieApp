namespace MovieApp.Web.main
{
    public interface INote
    {
        //erişim belirteçleri olmaz. altı sınıflar hepsini kullanmak zorundadır.
        //metodun bodysi olmayacak
        int Id { get; set; } 
        DateTime CreatedDate { get; set; }
        string GetContent ();

    }
}
