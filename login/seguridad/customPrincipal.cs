using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using login.Models;
namespace login.seguridad
{
    public class customPrincipal : IPrincipal
    {
        private cuentas cuentas;
  
        public customPrincipal(cuentas cuentas)
        {
            this.cuentas = cuentas;
            this.Identity = new GenericIdentity(cuentas.username);
        }
        public IIdentity Identity
        {
            get; set;
         
        }

        public bool IsInRole(string role)
        {
            var roles = role.Split(new char[] { ',' });
            return roles.Any(r => this.cuentas.roles.Contains(r));
        }
    }
}