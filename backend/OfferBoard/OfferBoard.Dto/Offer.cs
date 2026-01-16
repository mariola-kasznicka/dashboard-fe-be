namespace OfferBoard.Dto
{
    public class Offer
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public OfferStatusEnumeration Status { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? PublishDate { get; set; }
        public DateTime? ArchivedDate { get; set; }
        
        // Navigation properties
        public User User { get; set; } = null!;
        public Industry Industry { get; set; } = null!;
        public Localization Localization { get; set; } = null!;
        public ContractType ContractType { get; set; } = null!;
        public WorkingMode WorkingMode { get; set; } = null!;
        public WorkType WorkType { get; set; } = null!;
        public ExperienceLevel ExperienceLevel { get; set; } = null!;

    }
}

public enum OfferStatusEnumeration
{
   Draft,
   Published,
   Archived
}