using Microsoft.EntityFrameworkCore;
using RentDress.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace RentDress.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<DressEntity> DressList { get; set; }
        public DbSet<UserEntity> UserList { get; set; }
        public DbSet<RentEntity> RentList { get; set; }
        public DbSet<AvailabilityEntity> AvailabilityList { get; set; }
        public DbSet<RentDetailsEntity> RentDetailsList { get; set; }
       

    }
}
