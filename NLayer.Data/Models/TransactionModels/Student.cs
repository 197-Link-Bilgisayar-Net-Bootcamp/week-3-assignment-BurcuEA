using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Models.TransactionModels
{
    public class Student
    {
        public int Age { get; set; }

        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
    }
}
