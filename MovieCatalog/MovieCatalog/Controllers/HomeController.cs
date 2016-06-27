using MovieCatalog.EF;
using MovieCatalog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieCatalog.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetMovies()
        {
            DAL _dal = new DAL();
            List<Movie> movies = _dal.movies.ToList();
            return Json(movies, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult SaveMovie(Movie _oMovie)
        {
            DAL _oDAL = new DAL();
            _oDAL.movies.Add(_oMovie);
            _oDAL.SaveChanges();

            List<Movie> ListOfMovies = _oDAL.movies.ToList();
            return Json(ListOfMovies, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult GetMovieByID(int id)
        {
            DAL _oDAL = new DAL();
            Movie _oMovie = new Movie();
            _oMovie = _oDAL.movies.Find(id);
            return Json(_oMovie, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult UpdateMovie(Movie _oMovie)
        {
            DAL _oDAL = new DAL();
            _oDAL.Entry(_oMovie).State = System.Data.Entity.EntityState.Modified;
            _oDAL.SaveChanges();

            List<Movie> ListOfMovies = _oDAL.movies.ToList();
            return Json(ListOfMovies, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult DeleteMovie(int id)
        {
            DAL _oDAL = new DAL();
            Movie _oMovie = new Movie();
            _oMovie = _oDAL.movies.Find(id);
            _oDAL.Entry(_oMovie).State = System.Data.Entity.EntityState.Deleted;
            _oDAL.SaveChanges();

            List<Movie> ListOfMovies = _oDAL.movies.ToList();
            return Json(ListOfMovies, JsonRequestBehavior.AllowGet);
        }
    }
}