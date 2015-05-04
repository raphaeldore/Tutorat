using System.Data.Entity;

namespace DataLayer.Model
{
    public class TutoratDbContext : DbContext
    {
        public DbSet<Tutor> Tutors { get; set; }
        public DbSet<HelpedStudent> Students { get; set; }
        public DbSet<TutoringSession> TutoringSessions { get; set; }
    }
}