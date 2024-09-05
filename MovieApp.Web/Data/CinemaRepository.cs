using MovieApp.Web.Models;

namespace MovieApp.Web.Data
{
    public class CinemaRepository
    {
        private static readonly List<Cinema> _cinemas = null;

        static CinemaRepository()
        {
            _cinemas = new List<Cinema>()
            {
                new Cinema
                {
                    CinemaId = 1,
                    Name = "Cinemaximum Kanyon",
                    Address = "Kanyon Alışveriş Merkezi, Levent, İstanbul, Turkey",
                    Latitude = "41.078964",
                    Longitude = "29.012179"
                },
                new Cinema
                {
                    CinemaId = 2,
                    Name = "Cinemaximum Zorlu Center",
                    Address = "Zorlu Center, Beşiktaş, İstanbul, Turkey",
                    Latitude = "41.067461",
                    Longitude = "29.018360"
                },
                new Cinema
                {
                    CinemaId = 3,
                    Name = "AFM İstinyePark",
                    Address = "İstinyePark Alışveriş Merkezi, Sarıyer, İstanbul, Turkey",
                    Latitude = "41.110491",
                    Longitude = "29.024607"
                },
                new Cinema
                {
                    CinemaId = 4,
                    Name = "Cinemaximum City’s",
                    Address = "City’s Alışveriş Merkezi, Nişantaşı, İstanbul, Turkey",
                    Latitude = "41.046532",
                    Longitude = "28.988175"
                },
                new Cinema
                {
                    CinemaId = 5,
                    Name = "Cinemaximum Forum Bornova",
                    Address = "Forum Bornova Alışveriş Merkezi, Bornova, İzmir, Turkey",
                    Latitude = "38.464592",
                    Longitude = "27.218795"
                }
            };
        }

        public static List<Cinema> Cinemas
        {
            get { return _cinemas; }
        }

        public static Cinema GetById(int id)
        {
            return _cinemas.FirstOrDefault(c => c.CinemaId == id);
        }
    }
}
