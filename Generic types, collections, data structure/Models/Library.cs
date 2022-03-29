using Generic_types__collections__data_structure.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_types__collections__data_structure.Models
{
    internal class Library
    {
        public int BookLimit { get; set; }
        List<Book> Books = new List<Book>();

        public Library(int booklimit)
        {
            BookLimit = booklimit;
        }
      
        public void AddBook(Book book)
        {
          
            if (Books.Count<BookLimit)
            {
                Books.Add((book);
                return;
            }
            else
            {
                throw new CapacityLimitException("limiti ashdi");
            }

        }
        public void GetBookById(int? id)
        {
            if (id == null)
            {
                throw new NullReferenceException("Bosh ola bilmez");
            }
          return  null;
            
        }
        public void RemoveById(int? id)
        {
            foreach (var item in Books)
            {
                if (item.Id == id)
                {
                    Books.Remove(item);
                }
                else if(id==null)
                {
                    throw new NullReferenceException("bosh deyil");
                }
            }throw new NotFoundException("yoxdur");
        }

    }
}
