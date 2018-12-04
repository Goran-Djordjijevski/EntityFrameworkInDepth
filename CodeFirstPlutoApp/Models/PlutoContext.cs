﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstPlutoApp.Models
{
    public class PlutoContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }

        public DbSet<Author> Authors { get; set; }

        public DbSet<Tag> Tags { get; set; }

        public PlutoContext() : base(nameOrConnectionString: "name=DefaultConnection")
        {

        }
    }
}
