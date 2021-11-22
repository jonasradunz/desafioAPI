using Microsoft.EntityFrameworkCore;
using desafioAPI.Models;

namespace desafioAPI.Data
{

	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options)
			: base(options)
		{
		}

		public DbSet<Usuario> Usuarios { get; set; }

	}
}