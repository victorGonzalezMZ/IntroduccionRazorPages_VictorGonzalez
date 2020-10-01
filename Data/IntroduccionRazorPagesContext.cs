using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IntroduccionRazorPages.Models;

namespace IntroduccionRazorPages.Data
{
    public class IntroduccionRazorPagesContext : DbContext
    {
        public IntroduccionRazorPagesContext (DbContextOptions<IntroduccionRazorPagesContext> options)
            : base(options)
        {
        }

        public DbSet<IntroduccionRazorPages.Models.User> User { get; set; }
    }
}
