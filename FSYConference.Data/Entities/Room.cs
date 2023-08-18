namespace FSYConference.Data.Entities
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Capacity { get; set; }

        public ICollection<Participant> Participants { get; } = new List<Participant>();
        public ICollection<Counselor> Counselors { get; } = new List<Counselor>();
    }
}
