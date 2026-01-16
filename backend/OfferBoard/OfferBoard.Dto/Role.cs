namespace OfferBoard.Dto;

public class Role
{
    public int Id { get; set; }
    public required string Name { get; set; }
}

public enum RoleTypeEnumeration
{
    Administrator,
    Client,
    Company
}