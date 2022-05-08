using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.DAL.Entities
{
    public class LocationDetails:Entity
    {
        public int СityID { get; set; }
        public City City { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public List<Booking> Bookings1 { get; set; }
        public List<Booking> Bookings2 { get; set; }
        public List<Contact> Contacts { get; set; }

    }
}
