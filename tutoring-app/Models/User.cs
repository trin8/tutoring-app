﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tutoring_app.Models
{
    /// <summary>
    /// Represents a user of this web app
    /// </summary>
    public abstract class User
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }
        public int Email { get; set; }
    }
}
