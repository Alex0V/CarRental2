using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.BLL.DTO.Responses
{
    public class ReviewResponse
    {
        public int CarID { get; set; }
        public int ClientID { get; set; }
        public string Rating { get; set; }
        public string TextReviews { get; set; }
    }
}
