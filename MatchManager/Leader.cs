﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MatchManager
{
    public class Leader
    {
        [Key]
        public string id { get; set; }

        public string name { get; set; }

        public string phone { get; set; }

        public string idteam { get; set; }

        public Leader()
        {

        }

        public Leader(string id, string name, string phone, string idteam)
        {
            this.id = id;
            this.name = name;
            this.phone = phone;
            this.idteam = idteam;
        }
    }
}
