﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOTPiSP__2
{
    class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public byte[] Key { get; set; }
        public byte[] Salt { get; set; }
        public UserProfile Profile { get; set; }
    }
}
