using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace login.Models
{   
    public class modelo_cuentas
    { private List<cuentas> lista_cuentas = new List<cuentas>();
  

        public modelo_cuentas()
        {

            lista_cuentas.Add(new cuentas { username = "c1", password = "123123", roles = new string[] {"0","1","2","3" } });
            lista_cuentas.Add(new cuentas { username = "c2", password = "123123", roles = new string[] { "0", "1" } });
            lista_cuentas.Add(new cuentas { username = "c3", password = "123123", roles = new string[] { "0" } });
            lista_cuentas.Add(new cuentas { username = "c4", password = "123123", roles = new string[] { "0", "1", "2" } });
        }
        public cuentas find(string user)
        {
            return lista_cuentas.Where(acc => acc.username.Equals(user)).FirstOrDefault();
        }
        public cuentas login(string user, string pass)

        {
            return lista_cuentas.Where(acc => acc.username.Equals(user) && acc.password.Equals(pass)).FirstOrDefault();
        }
    
    }
}