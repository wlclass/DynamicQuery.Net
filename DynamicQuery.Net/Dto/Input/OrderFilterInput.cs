﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicQuery.Net.Dto.Input
{
    public class OrderFilterInput
    {
        public List<FilterInput> Filter { get; set; }
        public List<OrderInput> Order { get; set; }
    }
}
