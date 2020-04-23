using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MatchManager
{
    public class Referee
    {
        [Key]
        public string id { get; set; }

        public string name { get; set; }

        public string phone { get; set; }

        public string ismajor { get; set; }

        public string idteam { get; set; }

        public Referee()
        {

        }

        public Referee(string id, string name, string phone, string ismajor, string idteam)
        {
            this.id = id;
            this.name = name;
            this.phone = phone;
            this.ismajor = ismajor;
            this.idteam = idteam;
        }
    }
}
