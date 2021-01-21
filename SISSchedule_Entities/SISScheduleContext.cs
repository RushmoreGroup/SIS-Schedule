using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
namespace SISSchedule_Entities
{

    /// <summary>
    /// SIS Schedule context
    /// </summary>
    public partial class SISScheduleContext : DbContext

    {
        /// <summary>
        /// default constructor
        /// </summary>
        public SISScheduleContext()
        {

        }

        public SISScheduleContext(DbContextOptions<SISScheduleContext> options) : base(options)
        {
            ChangeTracker.LazyLoadingEnabled = false;
        }

        public  virtual DbSet<Providers>  providers { get; set; }
       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseLazyLoadingProxies()
                    .UseSqlServer("");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            base.OnModelCreating(modelBuilder);
            #region Provider Model
            modelBuilder.Entity<Providers>(entity =>
            {
                entity.HasKey(e => e.RecordID);
            });

            #endregion



        }
    }

}
