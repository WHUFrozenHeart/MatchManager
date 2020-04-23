using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MatchManager
{
    public class RefereeGroup
    {
        [Key]
        public string num { get; set; }

        public string idgroup { get; set; }

        public string idreferee { get; set; }

        public RefereeGroup()
        {

        }

        public RefereeGroup(string num, string idgroup, string idreferee)
        {
            this.num = num;
            this.idgroup = idgroup;
            this.idreferee = idreferee;
        }
    }
}
