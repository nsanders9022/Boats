﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Boats.Models
{
    public class AssociateUser : IdentityUser
    {
        public List<Sale> Sales { get; set; }
    }
}
