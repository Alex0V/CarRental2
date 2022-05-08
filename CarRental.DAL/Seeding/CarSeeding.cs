using CarRental.DAL.Entities;
using CarRental.DAL.Interfaces;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.DAL.Seeding
{
    public class CarSeeding : ISeeder<Car>
    {
        private static readonly List<Car> car = new List<Car>()
        {
            new Car()
            {
                Id = 1,
                CarName="VW POLO SEDAN",
                LicensePlates="АВ 4324 BB",
                Price = 1200,
                Pledge = 13500,
                PassengerSeats ="5",
                TrunkVolume="460",
                FuelConsumption="6-8",
                NumberOfDoors="4",
                GearboxTypeID=1,
                EngineCapacity="1.4",
                FuelTypeID=1,
                CarTypeID=4,
                FotoName="VW POLO SEDAN.jpg",
            },
            new Car()
            {
                Id = 2,
                CarName="FORD FIESTA",
                LicensePlates="AB 3354 BB",
                Price = 1100,
                Pledge = 13100,
                PassengerSeats ="5",
                TrunkVolume="292",
                FuelConsumption="6-7",
                NumberOfDoors="5",
                GearboxTypeID=1,
                EngineCapacity="1.6",
                FuelTypeID = 1,
                CarTypeID=4,
                FotoName="FORD FIESTA.jpg",
            },
            new Car()
            {
                Id = 3,
                CarName="NISSAN JUKE",
                LicensePlates="AB 6544 EC",
                Price = 1400,
                Pledge = 17500,
                PassengerSeats ="5",
                TrunkVolume="520",
                FuelConsumption="6-8",
                NumberOfDoors="5",
                GearboxTypeID=1,
                EngineCapacity="1.6",
                FuelTypeID=1,
                CarTypeID=2,
                FotoName="NISSAN JUKE.jpg",
            },
            new Car()
            {
                Id = 4,
                CarName="KIA-SPORTAGE",
                LicensePlates="AA 8472 CE",
                Price = 200,
                Pledge = 23500,
                PassengerSeats ="5",
                TrunkVolume="580",
                FuelConsumption="6-9",
                NumberOfDoors="5",
                GearboxTypeID=1,
                EngineCapacity="1.6",
                FuelTypeID=1,
                CarTypeID=2,
                FotoName="KIA-SPORTAGE.jpg",
            },
            new Car()
            {
                Id = 5,
                CarName="SKODA OCTAVIA A8",
                LicensePlates="AA 1432 BC",
                Price = 1500,
                Pledge = 21000,
                PassengerSeats ="5",
                TrunkVolume="500",
                FuelConsumption="5-7",
                NumberOfDoors="4",
                GearboxTypeID=1,
                EngineCapacity="1.6",
                FuelTypeID=1,
                CarTypeID=6,
                FotoName="SKODA OCTAVIA A8.jpg",
            },
            new Car()
            {
                Id = 6,
                CarName="TOYOTA COROLLA",
                LicensePlates="AA 2431 CB",
                Price = 1400,
                Pledge = 19000,
                PassengerSeats ="5",
                TrunkVolume="480",
                FuelConsumption="6-8",
                NumberOfDoors="4",
                GearboxTypeID=1,
                EngineCapacity="1.6",
                FuelTypeID=1,
                CarTypeID=6,
                FotoName="TOYOTA COROLLA.jpg",
            },
            new Car()
            {
                Id = 7,
                CarName="VW TOUAREG",
                LicensePlates="AA 1212 CB",
                Price = 5200,
                Pledge = 64700,
                PassengerSeats ="5",
                TrunkVolume="590",
                FuelConsumption="7.6",
                NumberOfDoors="5",
                GearboxTypeID=1,
                EngineCapacity="1.6",
                FuelTypeID=2,
                CarTypeID=7,
                FotoName="VW TOUAREG.jpg",
            },
            new Car()
            {
                Id = 8,
                CarName="BMW X5 M PAKET",
                LicensePlates="AA 2234 CB",
                Price = 10000,
                Pledge = 99000,
                PassengerSeats ="5",
                TrunkVolume="600",
                FuelConsumption="7.1",
                NumberOfDoors="5",
                GearboxTypeID=1,
                EngineCapacity="3.0",
                FuelTypeID=2,
                CarTypeID=7,
                FotoName="BMW X5 M PAKET.jpg",
            },
            new Car()
            {
                Id = 9,
                CarName="FORD MONDEO",
                LicensePlates="СA 4532 CB",
                Price = 2000,
                Pledge = 30000,
                PassengerSeats ="5",
                TrunkVolume="500",
                FuelConsumption="9-10",
                NumberOfDoors="4",
                GearboxTypeID=1,
                EngineCapacity="2.0",
                FuelTypeID=1,
                CarTypeID=5,
                FotoName="FORD MONDEO.jpg",
            },
            new Car()
            {
                Id = 10,
                CarName="AUDI A6 S-LINE",
                LicensePlates="AС 2443 CB",
                Price = 4500,
                Pledge = 410000,
                PassengerSeats ="5",
                TrunkVolume="565",
                FuelConsumption="9-10",
                NumberOfDoors="4",
                GearboxTypeID=1,
                EngineCapacity="2.0",
                FuelTypeID=1,
                CarTypeID=5,
                FotoName="AUDI A6 S-LINE.jpg",
            },
        };

        public void Seed(EntityTypeBuilder<Car> builder) => builder.HasData(car);
    }
}
