using Microsoft.EntityFrameworkCore;
using OfferBoard.Dto;
namespace OfferBoard.Dal;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
    {
    }

    public DbSet<Offer> Offers => Set<Offer>();
    public DbSet<User> Users => Set<User>();
    public DbSet<Industry> Industries => Set<Industry>();
    public DbSet<Localization> Localizations => Set<Localization>();
    public DbSet<ContractType> ContractTypes => Set<ContractType>();
    public DbSet<WorkingMode> WorkingModes => Set<WorkingMode>();
    public DbSet<WorkType> WorkTypes => Set<WorkType>();
    public DbSet<ExperienceLevel> ExperienceLevels => Set<ExperienceLevel>();
    public DbSet<Role> Roles => Set<Role>();
}