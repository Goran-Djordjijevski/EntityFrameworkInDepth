using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstPlutoApp.Models
{
    public class Author
    {
        public int Id { get; set; }

        public string Name { get; set; }

        // Navigation properties
        public IList<Course> Courses { get; set; }
    }
}
