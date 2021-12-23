using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    public class User
    {
        public string Person { get; set; }
        public int Age { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
