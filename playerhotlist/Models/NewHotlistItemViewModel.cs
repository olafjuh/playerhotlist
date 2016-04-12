using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace playerhotlist.Models
{
    public class NewHotlistItemViewModel
    {
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

        [DisplayName("Game:")]
        [Required(ErrorMessage = "Please select the applicable game.")]
        public IEnumerable<SelectListItem> GameList { get; set; }

        public NewHotlistItemViewModel()
        {
            GameList = new List<SelectListItem>();
        }
    }
}