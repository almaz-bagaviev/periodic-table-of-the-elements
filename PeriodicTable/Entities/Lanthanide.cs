namespace PeriodicTable.Entities;

public class Lanthanide : IElement
{
    public int Id { get; set; }
    public int AtomicNumber { get; set; }
    public string Symbol { get; set; }
    public string Name { get; set; }
    public double AverageAtomicMass { get; set; }
    public string AverageAtomicMassString { get; set; }

    /// <summary>
    /// Лантаноиды
    /// </summary>
    /// <param name="atomicNumber">Порядковый номер</param>
    /// <param name="symbol">Символ элемента</param>
    /// <param name="name">Название элемента</param>
    /// <param name="averageAtomicMass">Относительная Атомная масса</param>
    public Lanthanide(int atomicNumber, string symbol, string name, double averageAtomicMass)
    {
        this.AtomicNumber = atomicNumber;
        this.Symbol = symbol;
        this.Name = name;
        this.AverageAtomicMass = averageAtomicMass;
    }

    /// <summary>
    /// Лантаноиды
    /// </summary>
    /// <param name="atomicNumber">Порядковый номер</param>
    /// <param name="symbol">Символ элемента</param>
    /// <param name="name">Название элемента</param>
    /// <param name="averageAtomicMassString">[Относительная Атомная масса]</param>
    public Lanthanide(int atomicNumber, string symbol, string name, string averageAtomicMassString)
    {
        this.AtomicNumber = atomicNumber;
        this.Symbol = symbol;
        this.Name = name;
        this.AverageAtomicMassString = averageAtomicMassString;
    }
}
