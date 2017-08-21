using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BB.Models
{
    public class Client:Party
    {
       
        //[Key]
        //[ForeignKey("CountryId")]
        public int CountryId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int DialCode { get; set; }
        public int ContactNumber { get; set; }
        public byte[] Image { get; set; }
        public int AverageRating { get; set; }
       // public virtual Country Country { get; set; }
    }
}