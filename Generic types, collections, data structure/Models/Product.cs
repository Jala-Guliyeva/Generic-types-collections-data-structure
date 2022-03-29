using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_types__collections__data_structure.Models
{
    abstract class Product
    {
        public  int Id { get;  }
        private static int _id;
        public abstract string Name { get; set; }
        public abstract int Price { get; set; }
        public abstract int Count { get; set; }
        public abstract int TotalInCome { get; set; }
        public Product()
        {
            _id++;
            Id= _id;    
        }
        public abstract void ShowInfo();
        public abstract void Cell();

    }
}
