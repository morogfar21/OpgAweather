using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab10.Model
{
    public class ApiDb : DbContext
    {
        public ApiDb()
        {
        }

        public ApiDb(DbContextOptions<ApiDb> options)
        :base(options)
        {

        }

        public virtual DbSet<measurement>

    }
}
