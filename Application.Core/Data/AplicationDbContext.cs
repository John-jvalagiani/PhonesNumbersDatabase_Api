using Aplication.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplication.Core.Data
{
   public  class AplicationDbContext:DbContext
    {
        public DbSet<PhoneNumber> UserPhoneNumbers { get; set; }

        public AplicationDbContext(DbContextOptions<AplicationDbContext> options):base(options)
        {

        }


    }
}
