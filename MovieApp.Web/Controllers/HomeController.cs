using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieApp.Web.Models;
using MovieApp.Web.main;
using MovieApp.Web.Data;


namespace MovieApp.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(){

            /*
            string MovieTitle = "The Office";
            string MovieEx = "Michael Scott ve ofis arkadaşlarının hayatı";
            string MovieDirector = "Randall Einhorn";
            string[] Cast = {"John Krasinski", "Jenna Fischer"};
            
            var m = new Movie();
            m.Title = MovieTitle;
            m.Description = MovieEx;
            m.Director = MovieDirector;
            m.Players = Cast;
            m.ImageUrl = "1.jpg";
            */


            var model = new HomePageViewModel
            {
                PopularMovies = MovieRepository.Movies,
            };


            /*
            ViewBag.MovieTitle = MovieTitle;
            ViewBag.MovieEx = MovieEx;
            ViewBag.MovieDirector = MovieDirector;
            ViewBag.Cast = Cast; */

            return View("Index", model);
        }

        public IActionResult About()
        {
            NoteManager manager = new NoteManager();

            INote note = new TextNote()
            {
                CreatedDate = DateTime.Now,
                Text = "bu bir text node",
            };

            manager.AddNode(note);

            INote note2 = new ReminderNote()
            {
                CreatedDate = DateTime.Now,
                Text = "bu bir text node",
                ReminderDate = DateTime.Now,
            };

            manager.AddNode(note2);

            INote note3 = new ImgNote
            {
                ImgUrl = "path",
                Text = "Img text"
            };

            manager.AddNode(note3);

            var a= manager.DisplayAllNode();

            return View();
        }
    }
}