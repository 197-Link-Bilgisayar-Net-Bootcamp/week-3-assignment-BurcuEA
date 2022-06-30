using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.DTOs
{
    public class ProductFull
    {
        //public int Id { get; set; }
        //public DateTime CreatedDate { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        //public decimal Price { get; set; }      
        public string CategoryName { get; set; }
        public string Color { get; set; }

    }
}
