using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MatchManager
{
    public class Team
    {
        [Key]
        public string idteam { get; set; }

        public string name { get; set; }

        public string password { get; set; }

        public string ismajor { get; set; }

        public int firstage { get; set; }

        public int secondage { get; set; }

        public int thirdage { get; set; }

        public Team()
        {

        }

        public Team(string idteam, string name, string password, string ismajor, int firstage, int secondage, int thirdage)
        {
            this.idteam = idteam;
            this.name = name;
            this.password = password;
            this.ismajor = ismajor;
            this.firstage = firstage;
            this.secondage = secondage;
            this.thirdage = thirdage;
        }
    }
}
