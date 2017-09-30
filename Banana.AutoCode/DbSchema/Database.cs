﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Banana.AutoCode.DbSchema
{
    [Serializable]
    public class Database
    {
        public String Name { get; set; }

        public IList<Table> Tables { get; set; } 
    }
}
