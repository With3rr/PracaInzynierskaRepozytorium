﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRO.Domain.Command.Taste
{
    public class DeleteTasteCommand:ICommand
    {
        public Guid Id { get; set; }
    }
}