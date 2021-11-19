﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mustang.Database.Entity
{
    public class ApplicationUser:IdentityUser
    {
        public bool IsActive { get; set; }
    }
}
