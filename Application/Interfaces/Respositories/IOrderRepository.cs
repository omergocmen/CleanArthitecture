﻿using Domain.Entities.OrderDomain;
using Domain.Entities.ProductDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Respositories
{
    public interface IOrderRepository : IEntityRepository<Order>
    {
    }
}
