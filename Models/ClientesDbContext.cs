using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DataTableJquery.Models
{
    public class ClientesDbContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
    }
}