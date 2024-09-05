using MovieApp.Web.Models;

namespace MovieApp.Web.Data
{
    public class GenreRepository
    {
        private static readonly List<Genre> _genres = null;

        static GenreRepository(){
            _genres = new List<Genre>()
            {
            new Genre { GenreId = 1, Name="Macera", MovieList = new List<Movie>()},
            new Genre { GenreId = 2, Name = "Komedi" , MovieList = new List<Movie>()},
            new Genre { GenreId = 3, Name = "Romantik" , MovieList = new List < Movie >()},
            new Genre { GenreId = 4, Name = "Savaş" , MovieList = new List<Movie>()}
            };


            MovieRepository movieRepository = new MovieRepository();

            foreach(var genre in _genres)
            {
                foreach (var movie in movieRepository.GetMovies())
                {
                    if(genre.GenreId == movie.GenreId)
                    {
                        genre.MovieList.Add(movie);
                    }
                }
            }

        }


        public static List<Genre> Genres
        {
            get { return _genres; }
        }


        public static void Add(Genre genre)
        {
            _genres.Add(genre);
        }


        public static Genre GetById(int id)
        {
            return _genres.FirstOrDefault(m => m.GenreId == id);
        }


    }
}
