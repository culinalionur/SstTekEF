using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Data.Models
{
    public class Book
    {
        public int Id { get; set; }
        public String Author { get; set; }
        public String Name { get; set; }

        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
    }
}
