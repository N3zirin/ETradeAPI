﻿using ETradeAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETradeAPI.Application.Abstractions
{
    public interface IProductService
    {
        List<Product> GetProducts();
    }
}
