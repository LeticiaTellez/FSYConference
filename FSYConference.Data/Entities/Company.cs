namespace FSYConference.Data.Entities
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CounselorMaleId { get; set; }
        public int CounselorFemaleId { get; set; }
    }
}
