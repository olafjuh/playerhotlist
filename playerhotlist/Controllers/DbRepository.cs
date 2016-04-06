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

        public IEnumerable<HotlistItem> GetAllItems(int i)
        {
            if (i == 1)
                return ctx.HotlistItems.Where(c => c.game == "ARMA 3").ToList();
            if (i == 2)
                return ctx.HotlistItems.Where(c => c.game == "ACV").ToList();
            if (i == 3)
                return ctx.HotlistItems.Where(c => c.game == "CSGO").ToList();
            if (i == 4)
                return ctx.HotlistItems.Where(c => c.game == "SQUAD").ToList();

            return ctx.HotlistItems;
        }

        public void SaveItem(HotlistItem hotlistItem)
        {
            ctx.HotlistItems.Add(hotlistItem);
            ctx.SaveChanges();
        }

        public void EditItem(HotlistItem a)
        {
            HotlistItem b = ctx.HotlistItems.SingleOrDefault(c => c.id == a.id);
            b.playerName = a.playerName;
            b.game = a.game;
            b.b3ID = a.b3ID;
            b.chatlog = a.chatlog;
            b.aliases = a.aliases;
            b.creator = a.creator;
            b.teamspeakID = a.teamspeakID;
            b.situation = a.situation;
            b.reason = a.reason;
            ctx.SaveChanges();
            
        }

        public HotlistItem GetHotlistItem(int id)
        {
            HotlistItem item = ctx.HotlistItems.SingleOrDefault(c => c.id == id);
            return item;
        }

        // Account

        public Account GetAccount(string name, string password)
        {
            Account account = ctx.Accounts.SingleOrDefault(c => c.name == name && c.password == password);

            return account;
        }

        public void RegisterAccount(RegisterModel model)
        {
            Account account = new Account();
            account.name = model.name;
            account.password = model.password;
            ctx.Accounts.Add(account);
            ctx.SaveChanges();
        }

    }
}