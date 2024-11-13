using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayObject
{
    internal class Product
    {
        public int Id { get; set; }
        public string Pname { get; set; }

        public double Price { get; set; }

        public override string ToString()
        {
            return $"ID ={Id} ,ProductName= {Pname} ,Price ={Price}";

        }
    }
}
