using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Models.TransactionModels
{
    public class Teacher : BasePerson
    {
        public string Branch { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
