using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyFirstApplication.Models;
using MyFirstApplication.ViewModel;
namespace MyFirstApplication.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Id = 1, Name = "Dangal" };
            var customer = new List<Customer> { 
                new Customer{ Id = 1,Name = "Priyanka"} ,
                new Customer{ Id = 2,Name = "Neha"} 
            };
            var Viewmodel = new RandomViewmodel
            {
                movie = movie,
                customers = customer
            };
            //ViewData["movie"] = movie;

            return View(Viewmodel);
            //return Content("Hello from VS");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home");
        }
        public ActionResult Edit(int id)
        {
            return Content("Id =" + id);
        }
        public ActionResult Index(int? Pageind,string SortBy)
        {
            if(!Pageind.HasValue)
            {
                Pageind = 1;
            }
            if (string.IsNullOrWhiteSpace(SortBy))
                SortBy = "Name";
            return Content(string.Format("Page index={0} and Sort By={1}", Pageind, SortBy));
        }
        //Added constraint on month i.e. should be 2 digit & between 1 to 12
        [Route("movies/Released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult Released(int year,int month)
        {
           return Content(year + "/" + month);
        }
    }
}