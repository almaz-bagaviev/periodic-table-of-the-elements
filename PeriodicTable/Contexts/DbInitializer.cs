namespace PeriodicTable.Contexts;

public class DbInitializer
{
    Repository repository;
    public DbInitializer()
    {
        this.repository = new();
    }
    
    public void Initialize(ChemicalElementsContext context)
    {
        context.Database.EnsureCreated();
        if (context.ChemicalElementsTable.Any()) return;
        if (context.ActinidesTable.Any()) return;
        if (context.LanthanidesTable.Any()) return;
        if (context.LinksTable.Any()) return;

        foreach (var c in repository.ChemicalElements)
        {
            context.ChemicalElementsTable.Add(c);
        }

        foreach(var l in repository.Lanthanides)
        {
            context.LanthanidesTable.Add(l);
        }

        foreach (var a in repository.Actinides)
        {
            context.ActinidesTable.Add(a);
        }

        foreach (var e in repository.GetWebModel.LinkMainElements)
        {
            context.LinksTable.Add(e);
        }

        foreach (var e in repository.GetWebModel.LinkLanthanides)
        {
            context.LinksTable.Add(e);
        }

        foreach (var e in repository.GetWebModel.LinkActinides)
        {
            context.LinksTable.Add(e);
        }

        context.SaveChanges();
    }
}
