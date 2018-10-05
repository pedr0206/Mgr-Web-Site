using MgrWebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MgrWebSite.Data
{
    public class RoverCarRepository
    {
        private List<RoverCar> RoverCarList = new List<RoverCar>();

        static RoverCarRepository roverCarRepoSingleton;
        public static RoverCarRepository Instance
        {
            get
            {
                if (roverCarRepoSingleton == null)
                {
                    roverCarRepoSingleton = new RoverCarRepository();
                }
                return roverCarRepoSingleton;
            }
        }

        private RoverCarRepository()
        {
            RoverCarList.Add( new RoverCar("Rover 100" ,"The metro Rover", "Petrol", 1.4, new DateTime(1995,7,1),"Longbridge","Segment C",
                " <p><strong>The small Rover.</strong> The Metro is a city car that was produced by British Leyland (BL) and, later, the Rover Group from 1980 to 1998. It was launched in 1980 as the Austin Mini Metro. It was intended to complement and eventually replace the Mini, and was developed under the codename LC8. The Metro was named by What Car? as Car of The Year in 1983 as an MG, and again as a Rover in 1991.</p>"));
            RoverCarList.Add(new RoverCar("Rover 200", "Versatile car", "Petrol", 1.3, new DateTime(1985, 4, 1), "Oxford", "Segment B",
                "<p><strong>Middle low segment car</strong> There have been three distinct generations of the Rover 200.The first generation was a four - door saloon car based on the Honda Ballade.The second generation was available in three or five - door hatchback forms, as well a coupé and cabriolet(in relatively small numbers).Its sister model, the Honda Concerto was built on the same production line in Rover's Longbridge factory.</p>"));
            RoverCarList.Add(new RoverCar("Rover 400", "Versatile car", "Petrol", 1.4, new DateTime(1994, 4, 1), "Oxford", "Segment C",
                "<p><strong>The Rover 400 Series, and later the Rover 45, are a series of small family cars that were produced by the British manufacturer Rover from 1990 to 2005. The car was mutually developed during Rover's collaboration with Honda; the first generation 400 was co developed with the Honda Concerto, and the Mark II 400 being based on the Honda Domani/Civic.</p>"));
            RoverCarList.Add(new RoverCar("Rover 600", "Executive Saloon", "Diesel", 2.0, new DateTime(1994, 8, 1), "Longbridge", "Segment D",
                "<p><strong> The Rover 600 exterior was designed by Rover, a reskin of the European Honda Accord, also built in the United Kingdom by Honda in Swindon. The core structure and vast majority of the engineering content was sourced from Honda but the vehicles were designed at the same time, with a small Rover team on site in Japan. Colour and trim derivatives were also used to help separate the Rover from the Honda in the marketplace.</p>"));
            RoverCarList.Add(new RoverCar("Rover 800", "The Rover's flag ship", "Petrol", 2.7, new DateTime(1987, 8, 1), "Longbridge", "Segment E",
                "<p><strong>The flagship of Rover.</strong> The Rover 800 series is an executive car range manufactured by the Austin Rover Group subsidiary of British Leyland, and its successor the Rover Group from 1986 to 1999. It was also marketed as the Sterling in the United States. Co-developed with Honda, it was a close relative to the Honda Legend and the successor to the Rover SD1.</p>"));
        }

        public List<RoverCar> GetRoverCars()
        {
            return RoverCarList;
        }

        public RoverCar GetRoverCars(int id)
        {
            RoverCar roverCarToReturn = null;
            foreach (var roverCar in RoverCarList)
            {
                if (roverCar.Id == id)
                {
                    roverCarToReturn = roverCar;
                    break;
                }
            }
            return roverCarToReturn;
        }

        public void AddCar(string model, string description, string fuelType, double engineSize,
            DateTime productionStartPeriod, string assemblyPlant, string segment, string developmentHistoryHtml)
        {
            RoverCarList.Add(new RoverCar(model, description, fuelType, engineSize, productionStartPeriod, assemblyPlant, segment, developmentHistoryHtml));
        }
    }
}
