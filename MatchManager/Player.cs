using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MatchManager
{
    public class Player
    {
        [Key]
        public string num { get; set; }

        public string idplayer { get; set; }

        public string name { get; set; }

        public string id { get; set; }

        public string age { get; set; }

        public string sex { get; set; }

        public string grade { get; set; }

        public string idteam { get; set; }

        public string ismajor { get; set; }

        public Player()
        {

        }

        public Player(string num, string idplayer, string name, string id, string age, string sex, string grade, string idteam, string ismajor)
        {
            this.num = num;
            this.idplayer = idplayer;
            this.name = name;
            this.id = id;
            this.age = age;
            this.sex = sex;
            this.grade = grade;
            this.idteam = idteam;
            this.ismajor = ismajor;
        }
    }
}
