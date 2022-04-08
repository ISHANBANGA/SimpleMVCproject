using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstMVCProject.Models;  // added the package of MODEL here in CONTROLLER class  to make an object of dogviewmodel in here and assigning there value so that they can be called/show in VIEW 

namespace FirstMVCProject.Controllers
{
    public class HelloWorldController : Controller
    {
        private static List<DogViewModel> dogs = new List<DogViewModel>();  //list of type dogviewmodel

        public IActionResult Index()
        {
            return View(dogs);
            /*DogViewModel doggo = new DogViewModel()
            { Name = "Don",Age = 2};
            return View(doggo);
            // return View();  //# first exampleThis will use view folder that has same name aas method inside the folder which has same name as in controller without the name controller.*/
        }

        public IActionResult Create()
        {
            var dogVm = new DogViewModel();  //dogViewModel
            return View(dogVm);
        }

        public IActionResult CreateDog(DogViewModel dogViewModel)
        {
            // return View("Index");
            dogs.Add(dogViewModel);
            return RedirectToAction(nameof(Index));
        }
        public string Hello()
        {
            return "Whos there?";
        }
    }
}
