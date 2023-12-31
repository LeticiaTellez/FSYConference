﻿namespace FSYConference.Data.Entities
{
    public class Participant
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public bool Sex { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? EmergencyContact { get; set; }
        public int StakeId { get; set; }
        public int WardId { get; set; }
        public int CompanyId { get; set; }
        public int RoomId { get; set; }
        public bool Attendance { get; set; }

        public Stake Stake { get; set; }
        public Ward Ward { get; set; }
        public Company? Company { get; set; }
        public Room? Room { get; set; }
        public ICollection<Payment> Payments { get; } = new List<Payment>();
    }
}
