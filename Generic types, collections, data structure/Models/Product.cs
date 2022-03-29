using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_types__collections__data_structure.Models
{
    abstract class Product
    {
        public  int Id { get;  }
        private static int _id;
        public  string Name { get; set; }
        public  double Price { get; set; }
        public  int Count { get; set; }
        public  double TotalInCome { get; protected set; }
        public Product()
        {
            _id++;
            Id= _id;    
        }
        public abstract void ShowInfo();
        public abstract void Cell();

    }
}
