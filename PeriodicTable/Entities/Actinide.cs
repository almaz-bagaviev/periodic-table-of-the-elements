namespace PeriodicTable.Entities;

public class Actinide : IElement
{
    public int Id { get; set; }
    public int AtomicNumber { get; set; }

    [Column(TypeName = "nvarchar(2)")]
    public string Symbol { get; set; }
    public string Name { get; set; }

    [Column(TypeName = "nvarchar(8)")]
    public string AverageAtomicMass { get; set; }

    /// <summary>
    /// Актиноиды
    /// </summary>
    /// <param name="atomicNumber">Порядковый номер</param>
    /// <param name="symbol">Символ элемента</param>
    /// <param name="name">Название элемента</param>
    /// <param name="averageAtomicMass">Относительная Атомная масса</param>
    public Actinide(int atomicNumber, string symbol, string name, string averageAtomicMass)
    {
        this.AtomicNumber = atomicNumber;
        this.Symbol = symbol;
        this.Name = name;
        this.AverageAtomicMass = averageAtomicMass;
    }

    public Actinide()
    {

    }
}
