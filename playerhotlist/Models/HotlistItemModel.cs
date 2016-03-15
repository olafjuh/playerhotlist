using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace playerhotlist.Models
{
    public class HotlistItem
    {
        public int id { get; set; }
        public string playerName { get; set; }
        public string aliases { get; set; }
        public string b3ID { get; set; }
        public string teamspeakID { get; set; }
        public string reason { get; set; }
        public string situation { get; set; }
        public string chatlog { get; set; }
        public bool status { get; set; }
        public string game { get; set; }

        public HotlistItem()
        {

        }

        public HotlistItem(string playerName, string aliases, string b3ID, string ts3ID, string reason, string situation, string chatlog, bool status, string game)
        {
            this.playerName = playerName;
            this.aliases = aliases;
            this.b3ID = b3ID;
            this.reason = reason;
            this.situation = situation;
            this.chatlog = chatlog;
            this.status = status;
            this.game = game;
        }
    }
}