namespace OfferBoard.Dto
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        
        // Foreign key property
        public int RoleId { get; set; }
        
        // Navigation property
        public Role Role { get; set; } = null!;
        public DateTime RegistrationDate { get; set; }
        public bool IsActive { get; set; }
        public ICollection<Offer> Offers { get; set; } = new List<Offer>();
    }
}