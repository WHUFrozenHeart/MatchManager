using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MatchManager
{
    public class Match
    {
        [Key]
        public string idmatch { get; set; }

        public string name { get; set; }

        public string sex { get; set; }

        public string age { get; set; }

        public Match()
        {

        }

        public Match(string idmatch, string name, string sex, string age)
        {
            this.idmatch = idmatch;
            this.name = name;
            this.sex = sex;
            this.age = age;
        }
    }
}
