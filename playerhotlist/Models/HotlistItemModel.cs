using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace playerhotlist.Models
{
    public class HotlistItem
    {
        [Key]
        public int id { get; set; }
        [DisplayName("Player Name:")]
        [Required(ErrorMessage = "Please enter a player name.")]
        [StringLength(50)]
        public string playerName { get; set; }
        [DisplayName("Aliases: ")]
        public string aliases { get; set; }
        [DisplayName("B3 ID:")]
        [StringLength(50)]
        public string b3ID { get; set; }
        [DisplayName("Teamspeak 3 ID:")]
        [StringLength(50)]
        public string teamspeakID { get; set; }
        [DisplayName("Reason:")]
        [Required(ErrorMessage = "Please enter a reason for the hotlist.")]
        [StringLength(100)]
        public string reason { get; set; }
        [DisplayName("Situation")]
        [StringLength(1000)]
        public string situation { get; set; }
        [DisplayName("Chatlog:")]
        [StringLength(1000)]
        public string chatlog { get; set; }
        public bool status { get; set; }
        [DisplayName("Game:")]
        [Required(ErrorMessage = "Please enter the applicable game name.")]
        [StringLength(50)]
        public string game { get; set; }
        [DisplayName("Your name:")]
        [Required(ErrorMessage = "Your name is required.")]
        [StringLength(50)]
        public string creator { get; set; }

        public HotlistItem()
        {

        }

        public HotlistItem(string playerName, string aliases, string b3ID, string ts3ID, string reason, string situation, string chatlog, bool status, string game, string creator)
        {
            this.playerName = playerName;
            this.aliases = aliases;
            this.b3ID = b3ID;
            this.reason = reason;
            this.situation = situation;
            this.chatlog = chatlog;
            this.status = status;
            this.game = game;
            this.creator = creator;
        }
    }
}