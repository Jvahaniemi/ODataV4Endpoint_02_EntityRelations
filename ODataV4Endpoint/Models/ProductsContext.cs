using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;

namespace ODataV4Endpoint.Models
{
    public class ProductsContext : DbContext
    {
        // Web.config connection string
        public ProductsContext()
            : base("name=ProductsContext")
        {
        }
        public DbSet<Product> Products { get; set; }
        // DbSet to include Supplier table in the database:
        public DbSet<Supplier> Suppliers { get; set; }
    }
}