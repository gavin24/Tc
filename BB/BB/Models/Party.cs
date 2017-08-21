using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BB.Models
{
    public class Party
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastLoggedIn { get; set; }
        public string EmailAddress { get; set; }
        public bool IsActive { get; set; }
    }
}