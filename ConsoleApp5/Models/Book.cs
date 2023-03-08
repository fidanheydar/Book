using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Models
{
    internal class Book
    {
        public string Name { get; set; }
        public int PageCount { get; set; }  
      

        public Book(string name, int page)
        {
           this.Name = name;
            this.PageCount = page;
         
        }
    }
}
