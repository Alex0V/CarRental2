using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.DAL.Entities.Models
{
    public class ClientParameters : QueryStringParameters
    {
        public uint YearOfBirth { get; set; } 
    }
}
