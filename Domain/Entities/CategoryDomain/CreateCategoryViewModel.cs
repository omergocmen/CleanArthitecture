﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.CategoryDomain
{
    public class CreateCategoryViewModel
    {
        public Guid Guid { get; set; }
        public string CategoryName { get; set; }

    }
}
