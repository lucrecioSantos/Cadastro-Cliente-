using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CrudAspNetMvc.Models
{
    public class ClienteContext : DbContext
    {
        public ClienteContext() : base ("Escola")
        {
            Database.CreateIfNotExists();
        }

        public DbSet<Cliente> Clientes { get; set; }

      //  public System.Data.Entity.DbSet<CrudAspNetMvc.Models.Cliente> Clientes { get; set; }
    }
}