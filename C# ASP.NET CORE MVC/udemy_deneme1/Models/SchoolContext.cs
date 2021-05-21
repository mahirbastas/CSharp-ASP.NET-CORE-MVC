using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using udemy_deneme1.Entities;

namespace udemy_deneme1.Models
{
    public class SchoolContext:DbContext 
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {

        }
        public DbSet<Student> Student { get; set; }

    }
}
