namespace FSYConference.Data.Entities
{
    public class Counselor
    {
        public int Id { get; set; }
        public string IdentityCard { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public bool Sex { get; set; }
        public string PhoneNumber { get; set; }
        public string? Email { get; set; }
        public int StakeId { get; set; }
        public int WardId { get; set; }
        public int RoomId { get; set; }
        public bool Status { get; set; }

        public Stake Stake { get; set; }
        public Ward Ward { get; set; }
        public Room? Room { get; set; }
        public ICollection<Company> Companies { get; } = new List<Company>();
        public ICollection<MeetingAttendances> MeetingAttendances { get; } = new List<MeetingAttendances>();

    }
}