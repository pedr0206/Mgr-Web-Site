using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MgrWebSite.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MgrWebSite.Controllers
{
    public class AddCarController : Controller
    {
        // GET: AddCar
        public ActionResult Index()
        {
            return View("Index");
        }

        [HttpPost]
        // POST: AddCar/Details/5
        public ActionResult Add(string model, string description, string fuelType, double engineSize,
            DateTime productionStartPeriod, string assemblyPlant, string segment, string developmentHistoryHtml)
        {
            RoverCarRepository.Instance.AddCar(model, description, fuelType, engineSize, productionStartPeriod, assemblyPlant, segment, developmentHistoryHtml);
            return View("../ShowRoverCars/Index", RoverCarRepository.Instance.GetRoverCars());
        }

    }
}