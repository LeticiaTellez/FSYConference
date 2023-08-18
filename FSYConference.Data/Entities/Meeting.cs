namespace FSYConference.Data.Entities
{
    public class Meeting
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public ICollection<MeetingAttendances> MeetingAttendances { get; } = new List<MeetingAttendances>();
    }
}
