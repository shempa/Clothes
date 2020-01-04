using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Clothes.Models
{
    public class ClothesContext:DbContext
    {
        public ClothesContext()
            :base ("BDConnection")
        { }
        public DbSet<Clothes> Clothes { get; set; }
    }
}