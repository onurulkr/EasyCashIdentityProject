﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.EntityLayer.Concrete
{
    public class CustomerAccountProcess
    {
        public int CustomerAccountProcessId { get; set; }
        public string ProcessType { get; set; }
        public string Amount { get; set; }
        public DateTime ProcessDate { get; set; }
    }
}
