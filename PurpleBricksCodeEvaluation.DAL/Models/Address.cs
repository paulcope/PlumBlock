using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;


namespace PurpleBricksCodeEvaluation.DAL.Models
{
    public class Address
    {
        [DisplayName("Address Line 1")]
        public string AddressLine1 { get; set; }
        [DisplayName("Address Line 2")]
        public string AddressLine2 { get; set; }
        [DisplayName("Address Line 3")]
        public string AddressLine3 { get; set; }
        [DisplayName("Address Line 4")]
        public string AddressLine4 { get; set; }
        [DisplayName("Address Line 5")]
        public string AddressLine5 { get; set; }
        [DisplayName("PostCode")]
        public string PostCode { get; set; }
    }
}
