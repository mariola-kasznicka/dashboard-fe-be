using Microsoft.EntityFrameworkCore;
using OfferBoard.Dal;

var builder = WebApplication.CreateBuilder(args);

// Connection string is read from configuration, which can be overridden by environment variables:
// Set ConnectionStrings__DefaultConnection environment variable, or use User Secrets for local development
// Example: ConnectionStrings__DefaultConnection="Host=localhost;Port=5432;Database=offerboard;Username=postgres;Password=your_password"
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(
        builder.Configuration.GetConnectionString("DefaultConnection") 
        ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found. Set ConnectionStrings__DefaultConnection environment variable.")
    ));

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();
app.Run();
