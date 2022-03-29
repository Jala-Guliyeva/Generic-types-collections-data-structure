using Generic_types__collections__data_structure.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_types__collections__data_structure.Models
{
    internal class Book:Product
    {
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
       

        public override void Cell()
        {
            if (Count>0)
            {
                Count--;
                TotalInCome += Price;
                return;

            }
            throw new ProductCountIsZeroException("count is zero");
         
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Id:{Id} - AuthorName:{AuthorName} - PageCount:{PageCount} - Name{Name} - Price:{Price} -Count:{Count} ");
        }
    }
}
