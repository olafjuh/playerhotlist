using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace playerhotlist.Controllers
{
    public class HotlistContext : DbContext
    {
        public HotlistContext()
            : base("HotlistConnection")
        {
            Database.SetInitializer<HotlistContext>(null);
        }

        public DbSet<playerhotlist.Models.HotlistItem> HotlistItems { get; set; }
        public DbSet<playerhotlist.Models.Account> Accounts { get; set; }
    }
}