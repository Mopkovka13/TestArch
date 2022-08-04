using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    internal class MyDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Group> Group { get; set; }

        
    }
}
