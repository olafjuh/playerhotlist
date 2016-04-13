using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace playerhotlist.Models
{
    public class Role
    {
        [Key]
        public int Id { get; set; }

        public string name { get; set; }

        public Role()
        {

        }

        public Role(int Id, string name)
        {
            this.Id = Id;
            this.name = name;
        }

    }
}