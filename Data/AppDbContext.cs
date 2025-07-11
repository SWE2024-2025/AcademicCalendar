﻿using Microsoft.EntityFrameworkCore;
using System.Xml;

namespace AcademicYearCalendar.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Resource> Resources { get; set; }

        //public DbSet<AcademicProgram> AcademicProgram { get; set; }
        //public DbSet<StudySubject> StudySubject { get; set; }
        //public DbSet<Staff> Staff { get; set; }

        public DbSet<Appointment> Appointments { get; set; }

        
        //public DbSet<ResourceIdSequenceValue> SequenceValue { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.HasSequence<int>("ResourceId");

            modelBuilder.Entity<Appointment>()
                .Property(a => a.Recurrence)
                .HasColumnType("xml");

            modelBuilder.Entity<Appointment>()
                .Property(a => a.Resources)
                .HasColumnType("xml");

            modelBuilder.Entity<Resource>()
            .HasOne(r => r.ParentResource)
            .WithMany(r => r.ChildrenResources)
            .HasForeignKey(r => r.ParentId)
            .OnDelete(DeleteBehavior.Restrict); // Optional: prevent cascade delete

            //modelBuilder.Entity<AcademicProgram>()
            //.Property(e => e.Id);
            ////.HasDefaultValueSql("NEXT VALUE FOR ResourceId");

            //modelBuilder.Entity<StudySubject>()
            //.Property(e => e.Id);

            //modelBuilder.Entity<Staff>()
           //.Property(e => e.Id);

            //modelBuilder.Entity<ResourceIdSequenceValue>()
            //.HasNoKey().ToView(null);
        }


        //public int GetNextResourceId()
        //{
        //    var result = this.Set<ResourceIdSequenceValue>()
        //        .FromSqlRaw("SELECT NEXT VALUE FOR ResourceId AS Value")
        //        .ToList();

        //    var nextId = result.First().Value;
        //    return (int)nextId;
        //}
       
    }

    //public class ResourceIdSequenceValue
    //{
    //    public long Value { get; set; }
    //}


}
