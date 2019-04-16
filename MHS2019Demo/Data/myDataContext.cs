using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MHS2019Demo.Models
{
    public class myDataContext : DbContext
    {
        public myDataContext (DbContextOptions<myDataContext> options)
            : base(options)
        {
        }

        public DbSet<MHS2019Demo.Models.Feedback> Feedback { get; set; }
    }
}
