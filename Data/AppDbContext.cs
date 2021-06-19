using Microsoft.EntityFrameworkCore;
using PsDevs.Models;

namespace PsDevs.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Career> Careers { get; set; }
        public DbSet<TeamMember> TeamMembers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TeamMember>().HasData(
                new TeamMember()
                {
                    TeamMemberId = 1,
                    TeamMemberName = "PLEASURE NDHLOVU",
                    TeamMemberPosition = "FOUNDER",
                    TeamMemberImageUrl = "https://images.unsplash.com/photo-1586083702768-190ae093d34d?ixid=MnwxMjA3fDB8MHxzZWFyY2h8OXx8bWFufGVufDB8fDB8fA%3D%3D&ixlib=rb-1.2.1&w=1000&q=80"
                },
                new TeamMember()
                {
                    TeamMemberId = 2,
                    TeamMemberName = "SURPRISE MDLULI",
                    TeamMemberPosition = "CO-FOUNDER",
                    TeamMemberImageUrl = "https://images.unsplash.com/photo-1560241804-02b7b1bc9d55?ixid=MnwxMjA3fDB8MHxzZWFyY2h8Nnx8bWFufGVufDB8fDB8fA%3D%3D&ixlib=rb-1.2.1&w=1000&q=80"
                },
                new TeamMember()
                {
                    TeamMemberId = 3,
                    TeamMemberName = "SAM JONE",
                    TeamMemberPosition = "ARCHITECTURE",
                    TeamMemberImageUrl = "https://i.pinimg.com/originals/b5/d3/54/b5d354063dae4723a18195174019fc73.jpg"
                },
                new TeamMember()
                {
                    TeamMemberId = 4,
                    TeamMemberName = "ABIGAIL MNISI",
                    TeamMemberPosition = "SENIOR DEVELOPER",
                    TeamMemberImageUrl = "https://images.unsplash.com/photo-1544005313-94ddf0286df2?ixid=MnwxMjA3fDB8MHxzZWFyY2h8OXx8cGVyc29ufGVufDB8fDB8fA%3D%3D&ixlib=rb-1.2.1&w=1000&q=80"
                },
                new TeamMember()
                {
                    TeamMemberId = 5,
                    TeamMemberName = "PRINCE THWALA",
                    TeamMemberPosition = "SENIOR DEVELOPER",
                    TeamMemberImageUrl = "https://images.unsplash.com/photo-1570158268183-d296b2892211?ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTd8fGJsYWNrJTIwbWFsZXxlbnwwfHwwfHw%3D&ixlib=rb-1.2.1&w=1000&q=80"
                });
        }
    }
}
