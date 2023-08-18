namespace FSYConference.Data.Entities
{
    public class MeetingAttendances
    {
        public int Id { get; set; }
        public int MeetingId { get; set;}
        public int CounselorId { get; set; }

        public Meeting Meeting { get; set; }
        public Counselor Counselor { get; set; }
    }
}
