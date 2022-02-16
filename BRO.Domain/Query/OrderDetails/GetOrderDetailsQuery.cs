﻿using BRO.Domain.Query.DTO.OrderDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRO.Domain.Query.OrderDetails
{
    public class GetOrderDetailsQuery:IQuery<List<OrderDetailsDTO>>
    {
        public Guid OrderId { get; set; }
    }
}
