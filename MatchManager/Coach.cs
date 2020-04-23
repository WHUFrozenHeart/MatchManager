using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MatchManager
{
    public class Coach
    {
        [Key]
        public string id { get; set; }

        public string name { get; set; }

        public string sex { get; set; }

        public string phone { get; set; }

        public string idteam { get; set; }


        public Coach()
        {

        }

        public Coach(string id, string name, string sex, string phone, string idteam)
        {
            this.id = id;
            this.name = name;
            this.sex = sex;
            this.phone = phone;
            this.idteam = idteam;
        }
    }
}
