﻿using System;
using System.Collections.Generic;

#nullable disable

namespace StudentManagement.Models
{
    public partial class Account
    {
        public int AccountId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int? Role { get; set; }
    }
}
