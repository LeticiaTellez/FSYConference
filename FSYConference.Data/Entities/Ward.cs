namespace FSYConference.Data.Entities
{
    public class Ward
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BishopName { get; set; }
        public string? BishopPhoneNumer { get; set; }

        public ICollection<Participant> Participants { get; } = new List<Participant>();
        public ICollection<Counselor> Counselors { get; } = new List<Counselor>();
    }
}
