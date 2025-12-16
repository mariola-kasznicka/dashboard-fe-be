namespace OfferBoard.Dto
{
    public class Offer
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public User User { get; set; }
        public Industry Industry { get; set; }
        public Localization Localization { get; set; }
        public ContractType ContractType { get; set; }
        public WorkingMode WorkingMode { get; set; }
        public WorkType WorkType { get; set; }
        public ExperienceLevel ExperienceLevel { get; set; }
    }
}