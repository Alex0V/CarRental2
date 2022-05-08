using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.DAL.Entities
{
    public class Contact:Entity
    {
        public int LocationID { get; set; }
        public LocationDetails LocationDetails { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
