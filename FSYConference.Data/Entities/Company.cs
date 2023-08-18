using System.Reflection.Metadata;

namespace FSYConference.Data.Entities
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CounselorMaleId { get; set; }
        public int CounselorFemaleId { get; set; }

        public Counselor? CounselorMale { get; set; }
        public Counselor? CounselorFemale { get; set; }
        public ICollection<Participant> Participants { get; } = new List<Participant>();

    }
}
