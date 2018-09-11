using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CarDealership.Models;

namespace CarDealership.Controllers
{
    public class CarsController : Controller
    {
        [HttpGet("/cars")]
        public ActionResult Index()
        {
            List<Car> allCars = Car.GetAllCars();
            return View(allCars);
        }

        [HttpGet("/cars/new")]
        public ActionResult Form()
        {
            return View();
        }

        [HttpPost("/cars")]
        public ActionResult NewCar()
        {
            Car newCar = new Car(Request.Form["makeModel"], Request.Form["miles"], Request.Form["price"]);
            // Car newCar = new Car();
            // newCar.SetMakeModel(Request.Form["makeModel"]);
            // newCar.SetMiles(Request.Form["miles"]);
            // newCar.SetPrice(Request.Form["price"]);
            newCar.SaveCar();
            List<Car> allCars = Car.GetAllCars();
            return View("Index", allCars);
        }
    }
}
