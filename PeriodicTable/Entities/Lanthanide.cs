namespace PeriodicTable.Entities;

public class Lanthanide : IElement
{
    public int Id { get; set; }
    public int AtomicNumber { get; set; }

    [Column(TypeName = "nvarchar(2)")]
    public string Symbol { get; set; }
    public string Name { get; set; }

    [Column(TypeName = "nvarchar(8)")]
    public string AverageAtomicMass { get; set; }

    /// <summary>
    /// Лантаноиды
    /// </summary>
    /// <param name="atomicNumber">Порядковый номер</param>
    /// <param name="symbol">Символ элемента</param>
    /// <param name="name">Название элемента</param>
    /// <param name="averageAtomicMass">Относительная Атомная масса</param>
    public Lanthanide(int atomicNumber, string symbol, string name, string averageAtomicMass)
    {
        this.AtomicNumber = atomicNumber;
        this.Symbol = symbol;
        this.Name = name;
        this.AverageAtomicMass = averageAtomicMass;
    }

    public Lanthanide()
    {

    }
}
