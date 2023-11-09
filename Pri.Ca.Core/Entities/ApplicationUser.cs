﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pri.Ca.Core.Entities
{
    public class ApplicationUser : IdentityUser
    {
        //extend with own props
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public ICollection<Game> Games { get; set; }
    }
}
