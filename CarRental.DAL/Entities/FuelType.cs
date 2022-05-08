using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.DAL.Entities
{
    public class FuelType:Entity
    {
        public string Fuel_Type { get; set; }
        public List<Car> Cars { get; set; }

    }
}
