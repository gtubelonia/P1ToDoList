using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using POneToDoList.Models;

namespace POneToDoList.Data
{
    public class POneToDoListContext : DbContext
    {
        public POneToDoListContext (DbContextOptions<POneToDoListContext> options)
            : base(options)
        {
        }

        public DbSet<POneToDoList.Models.ToDo> ToDo { get; set; }
    }
}
