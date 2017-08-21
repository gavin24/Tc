using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BB.Models
{
    public class User:Party
    {
      //  [Key]
        //[ForeignKey("CountryId")]
        public int RoldeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int DialCode { get; set; }
        public int ContactNumber { get; set; }
        public int IdentificationTypeId { get; set; }
        public int IdNumber { get; set; }
        public int PassportNumber { get; set; }
        public bool HasAcceptedTermsAndConditions { get; set; }
    }
}