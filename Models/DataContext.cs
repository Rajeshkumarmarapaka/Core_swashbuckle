using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_swashbuckle.Models
{
    public class DataContext : DbContext
    {
        private readonly DbContextOptions<DataContext> _options;

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            _options = options;
        }


        public DbSet<Values> Values { set; get; }
    }
}
