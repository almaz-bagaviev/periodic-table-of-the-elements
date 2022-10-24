namespace PeriodicTable.Entities;

public interface IElement
{
    /// <summary>
    /// Порядковый номер
    /// </summary>
    public int AtomicNumber { get; set; }

    /// <summary>
    /// Символ элемента
    /// </summary>
    public string Symbol { get; set; }

    /// <summary>
    /// Название элемента
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Относительная Атомная масса
    /// </summary>
    public double AverageAtomicMass { get; set; }
}
