﻿using eShopSolution.Data.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    // Guid là kiểu duy nhất cho toàn hệ thống
    public class AppUser : IdentityUser<Guid>
    {
        public string Name { get; set; }
        public UserType UserType { get; set; }
        public List<Order> Orders { get; set; }
    }
}
