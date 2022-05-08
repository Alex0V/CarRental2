using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.DAL.Entities
{
    public class CarType:Entity
    {
        public string Car_Type { get; set; }
        public List<Car> Cars { get; set; }
    }
}
