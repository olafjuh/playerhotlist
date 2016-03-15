using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using playerhotlist.Models;

namespace playerhotlist.Controllers
{
    public class DbRepository
    {
        private HotlistContext ctx = new HotlistContext();

        public IEnumerable<HotlistItem> GetAllItems()
        {
            return ctx.HotlistItems;
        }
    }
}