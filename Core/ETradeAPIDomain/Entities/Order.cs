﻿using ETradeAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETradeAPI.Domain.Entities
{
    public class Order : BaseEntity
    {
        public string Address { get; set; }
        public string Description { get; set;}
        public ICollection<Product> Products { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
    }
}
