using Microsoft.EntityFrameworkCore;

namespace VerticalSlices.API.Database;

public class ApplicationDbContext(DbContextOptions options) 
    : DbContext(options)
{
    
}