using Microsoft.EntityFrameworkCore;
using System.Xml;
using static AcademicYearCalendar.Components.Settings.AddEditAcademicProgram;

namespace AcademicYearCalendar.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.HasSequence<int>("ResourceId");

            modelBuilder.Entity<AcademicProgram>()
            .Property(e => e.Id);
            //.HasDefaultValueSql("NEXT VALUE FOR ResourceId");

            modelBuilder.Entity<StudySubject>()
            .Property(e => e.Id);

            modelBuilder.Entity<Staff>()
           .Property(e => e.Id);

            modelBuilder.Entity<ResourceIdSequenceValue>()
            .HasNoKey().ToView(null);
        }


        public int GetNextResourceId()
        {
            var result = this.Set<ResourceIdSequenceValue>()
                .FromSqlRaw("SELECT NEXT VALUE FOR ResourceId AS Value")
                .ToList();

            var nextId = result.First().Value;
            return (int)nextId;
        }

        public DbSet<AcademicProgram> AcademicProgram { get; set; }
        public DbSet<StudySubject> StudySubject { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<ResourceIdSequenceValue> SequenceValue { get; set; }
    }

   
}
