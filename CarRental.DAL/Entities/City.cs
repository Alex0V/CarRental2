using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.DAL.Entities
{
    public class City:Entity
    {
        public string CityName { get; set; }
        public List<LocationDetails> LocationDetails { get; set; }
    }
}
