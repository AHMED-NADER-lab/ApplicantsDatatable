using ApplicantsDatatable.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicantsDatatable.Data
{
   public class ApplicantContext : DbContext
    {
        public ApplicantContext(DbContextOptions<ApplicantContext> options)
           : base(options)
        {

        }

        public DbSet<Application> Application { get; set; }
    }
}
