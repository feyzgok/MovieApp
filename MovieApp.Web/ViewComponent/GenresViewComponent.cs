using Microsoft.AspNetCore.Mvc;
using MovieApp.Web.Data;
using MovieApp.Web.Models;
using System.Collections.Generic;


namespace MovieApp.Web.ViewComponents
{
    public class GenresViewComponent: ViewComponent
    {
        
        public IViewComponentResult Invoke()
        {

            
            
            ViewBag.SelectedGenre = RouteData.Values["id"];

            /*
            var genreList = new List<Genre>()
            {
            new Genre { GenreId = 1, Name="Macera"},
            new Genre { GenreId = 2, Name = "Komedi" },
            new Genre { GenreId = 3, Name = "Romantik" },
            new Genre { GenreId = 4, Name = "Savaş" }
            };
            */
            return View(GenreRepository.Genres);
        }
    }
}