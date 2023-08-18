using FSYConference.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace FSYConference.Data
{
    public class FSYConferenceContext : DbContext
    {
        public FSYConferenceContext(DbContextOptions<FSYConferenceContext> options)
        : base(options)
        {
        }

        public DbSet<Company> Companies { get; set; } = null!;
        public DbSet<Counselor> Counselors { get; set; } = null!;
        public DbSet<Meeting> Meetings { get; set; } = null!;
        public DbSet<MeetingAttendances> MeetingAttendances { get; set; } = null!;
        public DbSet<Participant> Participants { get; set; } = null!;
        public DbSet<Payment> Payments { get; set; } = null!;
        public DbSet<Room> Rooms { get; set; } = null!;
        public DbSet<Stake> Stakes { get; set; } = null!;
        public DbSet<Ward> Wards { get; set; } = null!;
    }
}
