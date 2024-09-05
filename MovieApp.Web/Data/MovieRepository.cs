using MovieApp.Web.Models;

namespace MovieApp.Web.Data
{
    public class MovieRepository
    {
        private static readonly List<Movie> _movies = null;
        static MovieRepository()
        {
            _movies = new List<Movie>()
            {
                new Movie
                {
                    MovieId = 1,
                    Title = "film1",
                    Description = "açıklama 1",
                    Director = "Yönetmen 1",
                    Players = new string[] { "oyuncu 1.1", "oyuncu 1.2" },
                    ImageUrl = "1.jpg",
                    GenreId = 1,
                    Cinemas = new List < Cinema >() { new Cinema { CinemaId = 1, Name = "Cinemaximum Kanyon", Address = "Kanyon Alışveriş Merkezi, Levent, İstanbul, Turkey", Latitude = "41.078964", Longitude = "29.012179" }, new Cinema { CinemaId = 2, Name = "Cinemaximum Zorlu Center", Address = "Zorlu Center, Beşiktaş, İstanbul, Turkey", Latitude = "41.067461", Longitude = "29.018360" }, new Cinema { CinemaId = 3, Name = "AFM İstinyePark", Address = "İstinyePark Alışveriş Merkezi, Sarıyer, İstanbul, Turkey", Latitude = "41.110491", Longitude = "29.024607" } },
                },

                new Movie
                {
                    MovieId = 2,
                    Title = "film2",
                    Description = "açıklama 2",
                    Director = "Yönetmen 2",
                    Players = new string[] { "oyuncu 2.1", "oyuncu 2.2" },
                    ImageUrl = "2.jpg",
                    GenreId = 2,
                    Cinemas = new List < Cinema >() { new Cinema { CinemaId = 1, Name = "Cinemaximum Kanyon", Address = "Kanyon Alışveriş Merkezi, Levent, İstanbul, Turkey", Latitude = "41.078964", Longitude = "29.012179" }, new Cinema { CinemaId = 2, Name = "Cinemaximum Zorlu Center", Address = "Zorlu Center, Beşiktaş, İstanbul, Turkey", Latitude = "41.067461", Longitude = "29.018360" }, new Cinema { CinemaId = 3, Name = "AFM İstinyePark", Address = "İstinyePark Alışveriş Merkezi, Sarıyer, İstanbul, Turkey", Latitude = "41.110491", Longitude = "29.024607" } },

                },

                new Movie
                {
                    MovieId = 3,
                    Title = "film",
                    Description = "açıklama",
                    Director = "Yönetmen",
                    Players = new string[] { "oyuncu", "oyuncu" },
                    ImageUrl = "3.jpg",
                    GenreId = 3,
                    Cinemas = new List < Cinema >() { new Cinema { CinemaId = 1, Name = "Cinemaximum Kanyon", Address = "Kanyon Alışveriş Merkezi, Levent, İstanbul, Turkey", Latitude = "41.078964", Longitude = "29.012179" }, new Cinema { CinemaId = 2, Name = "Cinemaximum Zorlu Center", Address = "Zorlu Center, Beşiktaş, İstanbul, Turkey", Latitude = "41.067461", Longitude = "29.018360" }, new Cinema { CinemaId = 3, Name = "AFM İstinyePark", Address = "İstinyePark Alışveriş Merkezi, Sarıyer, İstanbul, Turkey", Latitude = "41.110491", Longitude = "29.024607" } },

                },

                new Movie
                {
                    MovieId = 4,
                    Title = "film1",
                    Description = "açıklama 1",
                    Director = "Yönetmen 1",
                    Players = new string[] { "oyuncu 1.1", "oyuncu 1.2" },
                    ImageUrl = "1.jpg",
                    GenreId = 3,
                    Cinemas = new List < Cinema >() { new Cinema { CinemaId = 1, Name = "Cinemaximum Kanyon", Address = "Kanyon Alışveriş Merkezi, Levent, İstanbul, Turkey", Latitude = "41.078964", Longitude = "29.012179" }, new Cinema { CinemaId = 2, Name = "Cinemaximum Zorlu Center", Address = "Zorlu Center, Beşiktaş, İstanbul, Turkey", Latitude = "41.067461", Longitude = "29.018360" }, new Cinema { CinemaId = 3, Name = "AFM İstinyePark", Address = "İstinyePark Alışveriş Merkezi, Sarıyer, İstanbul, Turkey", Latitude = "41.110491", Longitude = "29.024607" } },

                    },

                new Movie
                {
                    MovieId = 5,
                    Title = "film2",
                    Description = "açıklama 2",
                    Director = "Yönetmen 2",
                    Players = new string[] { "oyuncu 2.1", "oyuncu 2.2" },
                    ImageUrl = "2.jpg",
                    GenreId = 4,
                    Cinemas = new List < Cinema >() { new Cinema { CinemaId = 1, Name = "Cinemaximum Kanyon", Address = "Kanyon Alışveriş Merkezi, Levent, İstanbul, Turkey", Latitude = "41.078964", Longitude = "29.012179" }, new Cinema { CinemaId = 2, Name = "Cinemaximum Zorlu Center", Address = "Zorlu Center, Beşiktaş, İstanbul, Turkey", Latitude = "41.067461", Longitude = "29.018360" }, new Cinema { CinemaId = 3, Name = "AFM İstinyePark", Address = "İstinyePark Alışveriş Merkezi, Sarıyer, İstanbul, Turkey", Latitude = "41.110491", Longitude = "29.024607" } },

                },

                new Movie
                {
                    MovieId = 6,
                    Title = "film",
                    Description = "açıklama",
                    Director = "Yönetmen",
                    Players = new string[] { "oyuncu", "oyuncu" },
                    ImageUrl = "3.jpg",
                    GenreId = 1,
                    Cinemas = new List < Cinema >() { new Cinema { CinemaId = 1, Name = "Cinemaximum Kanyon", Address = "Kanyon Alışveriş Merkezi, Levent, İstanbul, Turkey", Latitude = "41.078964", Longitude = "29.012179" }, new Cinema { CinemaId = 2, Name = "Cinemaximum Zorlu Center", Address = "Zorlu Center, Beşiktaş, İstanbul, Turkey", Latitude = "41.067461", Longitude = "29.018360" }, new Cinema { CinemaId = 3, Name = "AFM İstinyePark", Address = "İstinyePark Alışveriş Merkezi, Sarıyer, İstanbul, Turkey", Latitude = "41.110491", Longitude = "29.024607" } },

                },

                };
        }
    


        public static List<Movie> Movies
        {
            get
            {
                return _movies;
            }
        }

        public static void Add(Movie movie)
        {
            _movies.Add(movie);
        }

        public static Movie GetById(int id)
        {
            return _movies.FirstOrDefault(m => m.MovieId == id);
        }


        public List<Movie> GetMovies()
        {
            return _movies;
        }
    }
}