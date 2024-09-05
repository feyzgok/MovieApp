using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using MovieApp.Web.Models;
using System.Xml.Linq;
using MovieApp.Web.Data;

public class MoviesController : Controller
{

    public IActionResult Index()
    {

        var movieList = MovieRepository.Movies;

        var model = new MoviesViewModel()
        {
            Movies = movieList,

        };

        return View("Movies", model);
    }


    public IActionResult List(int? genreId)
    {

        var controller=RouteData.Values["controller"];
        var action = RouteData.Values["action"];
        var genreid = RouteData.Values["genreId"];
        var data = RouteData;



        var movieList = MovieRepository.Movies;
        if (genreId !=null)
        {
            movieList = movieList.Where(m => m.GenreId == genreId).ToList();
        }

        var model = new MoviesViewModel()
        {
            Movies = movieList,

        };

        return View("Movies", model);
    }



    public IActionResult Content(int MovieId)
    {
        var movie = MovieRepository.Movies.FirstOrDefault(m => m.MovieId == MovieId);

        var model = new MovieCinemaViewModel()
        {
            Movies = new List<Movie> { movie },
            Cinemas = CinemaRepository.Cinemas,
        };

        return View("Content", model);
    }


    public IActionResult Detail(int MovieId)
    {
        var movie = MovieRepository.GetById(MovieId);
        if(movie == null){
            Console.WriteLine("Movie of details is null");
        }

        return View("Detail", movie);
    }
}