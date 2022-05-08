using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.DAL.Entities
{
    public class Car : Entity
    {
        public string CarName { get; set; }
        public string LicensePlates { get; set; }
        public int Price { get; set; }
        public int Pledge { get; set; }
        public string PassengerSeats { get; set; }
        public string TrunkVolume { get; set; }
        public string FuelConsumption { get; set; }
        public string NumberOfDoors { get; set; }
        public int GearboxTypeID { get; set; }
        public GearboxType GearboxType { get; set; }
        public string EngineCapacity { get; set; }
        public int FuelTypeID { get; set; }
        public FuelType FuelType { get; set; }
        public int CarTypeID { get; set; }
        public CarType CarType { get; set; }
        public string FotoName { get; set; }

        public List<Booking> Bookings { get; set; }
        public List<Review> Reviews { get; set; }
        
    }
}
