﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkDev.IKEA.DAL.Models
{
    public class Department : ModelBase
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public DateOnly CreationDate { get; set; }
    }
}
