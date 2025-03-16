using Microsoft.EntityFrameworkCore;

namespace RycAuth.Infrastructure.Context;

public sealed class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    
}