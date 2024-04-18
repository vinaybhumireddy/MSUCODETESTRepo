using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MSUFRIBCodeTest.Models;

namespace MSUFRIBCodeTest.Data
{
    public class MSUFRIBCodeTestContext : DbContext
    {
        public MSUFRIBCodeTestContext (DbContextOptions<MSUFRIBCodeTestContext> options)
            : base(options)
        {
        }

        public DbSet<MSUFRIBCodeTest.Models.Message> Message { get; set; } = default!;
    }
}
