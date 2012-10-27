using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BearCamp.Models
{
    public class DonationsModel
    {
        public int DonationsID { get; set; }
        public int DonorID { get; set; }
        public float DonationAmount { get; set; }
        public DateTime DonationsDate { get; set; }
        public string Comments { get; set; }
        public int DonationType { get; set; }

    }
}