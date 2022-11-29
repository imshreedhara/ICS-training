using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment_EFCodeFirst.Models;

namespace Assignment_EFCodeFirst.Controllers
{
    public class MovieController : Controller
    {
        MovieContext mc = new MovieContext();

        // GET: Movie
        public ActionResult Index()
        {
            return View(mc.Movies.ToList());
        }

        [HttpGet]
        public ActionResult create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult create(Movie movie)
        {
            mc.Movies.Add(movie);
            mc.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Movie m = mc.Movies.Find(id);
            return View(m);
        }

        //[HttpGet]
        //[Route("ById")]
        //public ActionResult GetByID(int Mid)
        //{
        //    var MovieList = Movie.Find(x => x.ID == Mid);
        //    return MovieList;
        //}



        [HttpPost]
        public ActionResult Edit(Movie movie)
        {
            Movie m = mc.Movies.Find(movie.Mid);
            m.Movie_Name = movie.Movie_Name;
            m.DateOfRelease = movie.DateOfRelease;
            mc.SaveChanges();
            return RedirectToAction("Index");
              
        }

        public ActionResult SearchMovieByYear(string find)
        {

            var getMovies = mc.Movies.Where(x => x.DateOfRelease.Year.ToString().Contains(find) || find == null).ToList();
            return View(getMovies);
        }

        public ActionResult Delete(int id)
        {
            Movie m = mc.Movies.Find(id);
            mc.Movies.Remove(m);
            mc.SaveChanges();
            return RedirectToAction("Index");    
        }
    }
}