﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yet_another_tool
{
    public class Table
    {
        public string name, number, id;
        
        public void create(string name, string number, string id)
        {
            this.name = name;
            this.number = number;
            this.id = id;
        }
    }
}
