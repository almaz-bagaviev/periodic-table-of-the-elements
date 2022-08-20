namespace PeriodicTable.Web;

public class Link
{
    public int Id { get; set; }
    public int AtomicNumber { get; set; }
    public string Url { get; set; }

    public Link(int atomicNumber, string url)
    {
        this.AtomicNumber = atomicNumber;
        this.Url = url;
    }
}
