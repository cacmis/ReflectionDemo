using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReflectionDemo
{
    public class ProductType
    {
        public int Id { get; set; }
        public string TypeCode { get; set; }
        public string TypeDescription { get; set; }
        public bool Active { get; set; }
        public List<Product> Products { get; set; }
    }
}