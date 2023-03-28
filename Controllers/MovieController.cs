using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Movies.Data;
using Movies.Models;
using Movies.ViewModel;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Controllers
{
    [Authorize(Roles ="Admin")]
    public class MovieController : Controller
    {
        private readonly ApplicationDbContext context;

        public MovieController(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IActionResult AddMovie()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddMovie(MovieViewModel model)
        {
            
                var file = Request.Form.Files;
                if (!file.Any())
                {
                    ModelState.AddModelError(string.Empty, "Somthing went wrong");
                    return View(model);
                }

                var poster = file.FirstOrDefault();
                var extension = new List<string>{ ".jpg",".png",".jfif"};
                if( !extension.Contains(Path.GetExtension(poster.FileName).ToLower() ))
                {
                    ModelState.AddModelError("Poster", "Poster should be png/ jpg/ jfif ");
                    return View(model);
                }

                using var dataStream = new MemoryStream();
                await poster.CopyToAsync(dataStream);

                var movie = new Movie
                {
                    Title=model.Title,
                    Description=model.Description,
                    Genre=model.Genre,
                    CreatedDate=model.CreatedDate,
                    Poster=dataStream.ToArray(),
                    Like=model.Like=0,
                    Dislike=model.Dislike=0

                };

                context.Add(movie);
                context.SaveChanges();
                
                return RedirectToAction("Index",controllerName: "Home");
            
            
        }
    }
}
