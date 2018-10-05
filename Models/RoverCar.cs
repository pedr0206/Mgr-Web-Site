using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MgrWebSite.Models
{
    public class RoverCar
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
        public string FuelType { get; set; }
        public double EngineSize { get; set; }
        public DateTime ProductionStartPeriod { get; set; }
        public string AssemblyPlant { get; set; }
        public string Segment { get; set; }
        public string DevelopmentHistoryHtml { get; set; }
        public string ImagePath
        {
            get
            {
                return Model + ".jpg";
            }
        }
        public string DisplayText
        {
            get
            {
                return Model + " history.";
            }
        }
        private static object _lock = new object();
        private static int _counter { get; set; }

        public RoverCar(string model, string description, string fuelType, double engineSize,
            DateTime productionStartPeriod, string assemblyPlant, string segment, string developmentHistoryHtml)
        {
            lock (_lock)
            {
                Id = ++_counter;
            }
            Model = model;
            Description = description;
            FuelType = fuelType;
            EngineSize = engineSize;
            ProductionStartPeriod = productionStartPeriod;
            AssemblyPlant = assemblyPlant;
            Segment = segment;
            DevelopmentHistoryHtml = developmentHistoryHtml;
        }
    }
}
