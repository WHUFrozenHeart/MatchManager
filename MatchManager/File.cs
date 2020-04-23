using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MatchManager
{
    public class File
    {
        [Key]
        public string idteam { get; set; }
        public byte[] file { get; set; }

        public File()
        {

        }

        public File(string idteam, byte[] file)
        {
            this.idteam = idteam;
            this.file = file;
        }
    }
}
