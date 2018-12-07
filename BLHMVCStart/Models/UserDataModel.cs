using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace BLHMVCStart.Models
{
    public class UserDataModel
    {
        [DisplayName("First Name")]
        public string FirstName { get; set;  }

        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [DisplayName("Email")]
        public string EmailAddress { get; set; }

        [DisplayName("Date Of Birth")]
        public string DateOfBirth { get; set; }
    }
}