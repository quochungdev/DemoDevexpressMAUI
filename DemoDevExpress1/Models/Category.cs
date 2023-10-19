using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDevExpress1.Models
{
    public class Category
    {
        private static int _nextId = 1;
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }


        public Category()
        {
            Id = _nextId++;
        }

    }
}
