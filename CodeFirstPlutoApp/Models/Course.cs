using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstPlutoApp.Models
{
    public class Course
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public CourseLevel Level { get; set; }

        public float FullPrice { get; set; }

        // Navigation properties
        public Author Author { get; set; }

        public IList<Tag> Tags { get; set; }
    }
}
