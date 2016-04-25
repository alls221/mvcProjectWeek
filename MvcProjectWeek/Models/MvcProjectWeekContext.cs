using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcProjectWeek.Models
{
    public class MvcProjectWeekContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public MvcProjectWeekContext() : base("name=MvcProjectWeekContext")
        {
        }

        public System.Data.Entity.DbSet<MvcProjectWeek.Models.Tops> Tops { get; set; }

        public System.Data.Entity.DbSet<MvcProjectWeek.Models.Shoes> Shoes { get; set; }

        public System.Data.Entity.DbSet<MvcProjectWeek.Models.Bottoms> Bottoms { get; set; }

        public System.Data.Entity.DbSet<MvcProjectWeek.Models.Accesories> Accesories { get; set; }
    }
}
