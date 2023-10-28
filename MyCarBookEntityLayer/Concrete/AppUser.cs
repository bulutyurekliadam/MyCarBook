﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCarBook.EntityLayer.Concrete
{
    public class AppUser : IdentityUser<int>
    {
        public string Name  { get; set; }
        public string Surname  { get; set; }
        public string? City { get; set; }
        public string? ImageUrl { get; set; }
    }
}
