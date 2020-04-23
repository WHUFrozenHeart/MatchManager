using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MatchManager
{
    public class Group
    {
        [Key]
        public string idgroup { get; set; }

        public string idmatch { get; set; }

        public Group()
        {

        }

        public Group(string idgroup, string idmatch)
        {
            this.idgroup = idgroup;
            this.idmatch = idmatch;
        }
    }
}
