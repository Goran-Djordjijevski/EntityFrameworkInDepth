namespace CodeFirstPlutoApp.Migrations
{
    using CodeFirstPlutoApp.Models;
    using System;
    using System.Collections.ObjectModel;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CodeFirstPlutoApp.Models.PlutoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CodeFirstPlutoApp.Models.PlutoContext context)
        {
            context.Authors.AddOrUpdate(a => a.Name,
                new Models.Author
                {
                    Name = "Author 1",
                    Courses = new Collection<Course>()
                    {
                        new Course() { Name = "Course for Author 1", Description = "Description 1" }
                    }
                });
        }
    }
}
