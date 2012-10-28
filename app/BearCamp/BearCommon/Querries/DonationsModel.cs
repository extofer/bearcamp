using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BearEF;

namespace BearCommon.Querries
{
    public class DonationsModel
    {
        public int DonationsID { get; set; }
        public int DonorID { get; set; }
        public decimal DonationAmount { get; set; }
        public DateTime DonationsDate { get; set; }
        public string Comments { get; set; }
        //public DonationTypeID DonationType { get; set; }

    }
}