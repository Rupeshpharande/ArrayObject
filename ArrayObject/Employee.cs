﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ArrayObject
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public double Salary { get; set; }

        public override string ToString()
        {
            return  $"ID ={Id} ,Name= {Name} ,Salary ={Salary}";
       
        }
    }
}