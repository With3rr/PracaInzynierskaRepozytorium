﻿using BRO.Domain.Query.DTO.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRO.Domain.Query.Product
{
    public class GetProductQuery:IQuery<ProductDTO>
    {
        public Guid Id { get; set; }
    }
}
