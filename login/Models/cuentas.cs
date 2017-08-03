using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace login.Models
{
    public class cuentas
    {
        [Display(Name = "username")]
        public string username { get; set; }

        [Display(Name = "password")]
        public string password { get; set; }

        [Display(Name = "roles")]
        public string[] roles { get; set; }
    }


}