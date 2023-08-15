namespace FSYConference.Data.Entities
{
    public class Payment
    {
        public int Id { get; set; }
        public int ParticipantId { get; set; }
        public float Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
