namespace PeriodicTable.Contexts;

public class ChemicalElementsContext : IdentityDbContext<ApplicationUser>
{
    public DbSet<ChemicalElement> ChemicalElementsTable { get; set; }
    public DbSet<Lanthanide> LanthanidesTable { get; set; }
    public DbSet<Actinide> ActinidesTable { get; set; }
    public DbSet<Link> LinksTable { get; set; }

    public ChemicalElementsContext(DbContextOptions options)
        : base(options)
    {

    }

}
