using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.DAL.Entities
{
    public class Client :Entity
    {
        public string ClientName { get; set; }
        public string ClientSurename { get; set; }
        public string ClientMiddlename { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<Booking> Bookings { get; set; }
        public List<Review> Reviews { get; set; }

    }
}
