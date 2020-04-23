using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MatchManager
{
    public class PlayerMatch
    {
        [Key]
        public string num { get; set; }

        public string idplayer { get; set; }

        public string idmatch { get; set; }

        public string grade { get; set; }

        public string idgroup { get; set; }

        public PlayerMatch()
        {

        }

        public PlayerMatch(string num, string idplayer, string idmatch)
        {
            this.num = num;
            this.idplayer = idplayer;
            this.idmatch = idmatch;
        }

        public PlayerMatch(string num, string idplayer, string idmatch, string grade, string idgroup)
        {
            this.num = num;
            this.idplayer = idplayer;
            this.idmatch = idmatch;
            this.grade = grade;
            this.idgroup = idgroup;
        }
    }
}
