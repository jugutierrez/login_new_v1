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
        PersonaDBContext db = new PersonaDBContext();
        private personas cuentas;
  
        public customPrincipal(personas cuentas)
        {
            this.cuentas = cuentas;
            this.Identity = new GenericIdentity(cuentas.nombre_persona);
        }
        public IIdentity Identity
        {
            get; set;
         
        }

    

         public bool IsInRole(string role)
        {
          var roles = role.Split(new char[] { ',' });
            List<personas> rol = db.personas.ToList();
            return true;
        }
    }
}