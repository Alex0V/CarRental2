using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.DAL.Entities
{
    public class Review:Entity
    {
        public int CarID { get; set; }
        public Car Car { get; set; }
        public int ClientID { get; set; }
        public Client Client { get; set; }
        public string Rating { get; set; }
        public string TextReviews { get; set; }
    }
}
