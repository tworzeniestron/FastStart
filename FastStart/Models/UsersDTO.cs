﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FastStart.Models
{
    public class UsersDTO
    {
        public int Id { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string eMail { get; set; }

        public List<RolesDTO> Roles { get; set; }
    }
}
