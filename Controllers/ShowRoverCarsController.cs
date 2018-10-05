using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MgrWebSite.Data;
using MgrWebSite.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MgrWebSite.Controllers
{
    public class ShowRoverCarsController : Controller
    {
        // GET: ShowRoverCars

        public List<RoverCar> roverCarList = new List<RoverCar>();
        [HttpGet]
        public ActionResult Index()
        {
            roverCarList = RoverCarRepository.Instance.GetRoverCars();
            return View(roverCarList);
        }
        [HttpGet]
        public ActionResult Detail(int? id)
        {
            var roverCar = RoverCarRepository.Instance.GetRoverCars(id.Value);
            if (id == null)
            {
                return View(roverCar);
            }
            return View(roverCar);
        }

        [HttpPost]
        public ActionResult Index(string productionPlant)
        {
            List<RoverCar> productionPlantList = new List<RoverCar>();
            List<RoverCar> roverCarList = RoverCarRepository.Instance.GetRoverCars();
            foreach (var roverCar in roverCarList)
            {
                if (roverCar.AssemblyPlant == productionPlant)
                {
                    productionPlantList.Add(roverCar);
                }
            }
            return View(productionPlantList);
        }
    }
}