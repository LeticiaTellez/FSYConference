namespace FSYConference.Data.Entities
{
    public class Stake
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PresidentName { get; set; }
        public string? PresidentPhoneNumber { get; set; }

        public ICollection<Participant> Participants { get; } = new List<Participant>();
        public ICollection<Counselor> Counselors { get; } = new List<Counselor>();
    }
}
