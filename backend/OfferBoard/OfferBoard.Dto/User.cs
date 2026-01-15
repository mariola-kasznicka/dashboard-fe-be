namespace OfferBoard.Dto
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
        public DateTime RegistrationDate { get; set; }
        public bool IsActive { get; set; }
        public ICollection<Offer> Offers { get; set; } = new List<Offer>();
    }
}