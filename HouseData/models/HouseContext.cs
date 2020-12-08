using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HouseData.models
{
    public class HouseContext:DbContext
    {
        public HouseContext(DbContextOptions<HouseContext> options) : base(options)
        {

        }

        public DbSet<DataHouse> dataHouses { get; set; }
    }
}
