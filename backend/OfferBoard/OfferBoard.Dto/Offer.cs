namespace OfferBoard.Dto
{
    public class Offer
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; }
        public OfferStatusEnumeration Status { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? PublishDate { get; set; }
        public DateTime? ArchivedDate { get; set; }
        public User User { get; set; } = null!;
        public Industry Industry { get; set; }
        public Localization Localization { get; set; }
        public ContractType ContractType { get; set; }
        public WorkingMode WorkingMode { get; set; }
        public WorkType WorkType { get; set; }
        public ExperienceLevel ExperienceLevel { get; set; }
    }
}

public enum OfferStatusEnumeration
{
   Draft,
   Published,
   Archived
}