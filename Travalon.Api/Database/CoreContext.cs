using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Travalon.Api.Models;

namespace Travalon.Api.Database
{
    public class CoreContext: DbContext
    {
        public CoreContext(DbContextOptions<CoreContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Activity> Activities { get; set; }
    }
}
