using Microsoft.EntityFrameworkCore;
using NordicDoor.Models;

namespace NordicDoorWeb.DataAccess;

public class ApplicationDbContext :DbContext
{
	public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
	{
	}

	public DbSet<Suggestion> Suggestions { get; set; }

}

