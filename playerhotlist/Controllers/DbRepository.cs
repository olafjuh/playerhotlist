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
                return ctx.HotlistItems.Where(c => c.game == "arma").ToList();
            if (i == 2)
                return ctx.HotlistItems.Where(c => c.game == "acv").ToList();
            if (i == 3)
                return ctx.HotlistItems.Where(c => c.game == "csgo").ToList();
            if (i == 4)
                return ctx.HotlistItems.Where(c => c.game == "squad").ToList();

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
            b.status = a.status;
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

        public Account GetAccount(int id)
        {
            return ctx.Accounts.SingleOrDefault(c => c.Id == id);
        }

        public void RegisterAccount(RegisterModel model)
        {
            Account account = new Account();
            account.name = model.name;
            account.password = model.password;
            account.roleID = 10;
            ctx.Accounts.Add(account);
            ctx.SaveChanges();
        }

        public bool IsValidatedUser(string username, string password)
        {
            IEnumerable<Account> list = ctx.Accounts;
            bool a = ((ctx.Accounts.SingleOrDefault(c => c.name == username && c.password == password)) != null);

            return a;
        }

        public IEnumerable<Account> GetAllAccounts()
        {
            return ctx.Accounts.ToList();
        }

        public void UpdateAccount(Account accountB)
        {
            Account accountA = ctx.Accounts.SingleOrDefault(c => c.Id == accountB.Id);

        }
    }
}