﻿namespace PeriodicTable.Entities;

public class ChemicalElement: IElement
{
    private static int Id;
    public int AtomicNumber { get; set; }
    public string Symbol { get; set; }
    public string Name { get; set; }
    public double AverageAtomicMass { get; set; }
    public string AverageAtomicMassString { get; set; }


    public ChemicalElement()
    {
        Id = 0;
    }
    private static int GetId()
    {
        Id++;
        return Id;
    }

    /// <summary>
    /// Химический элемент
    /// </summary>
    /// <param name="atomicNumber">Порядковый номер</param>
    /// <param name="symbol">Символ элемента</param>
    /// <param name="name">Название элемента</param>
    /// <param name="averageAtomicMass">Относительная Атомная масса</param>
    public ChemicalElement(int atomicNumber, string symbol, string name, double averageAtomicMass)
    {
        Id = GetId();
        this.AtomicNumber = atomicNumber;
        this.Symbol = symbol;
        this.Name = name;
        this.AverageAtomicMass = averageAtomicMass;
    }

    /// <summary>
    /// Химический элемент
    /// </summary>
    /// <param name="atomicNumber">Порядковый номер</param>
    /// <param name="symbol">Символ элемента</param>
    /// <param name="name">Название элемента</param>
    /// <param name="averageAtomicMassString">[Относительная Атомная масса]</param>
    public ChemicalElement(int atomicNumber, string symbol, string name, string averageAtomicMassString)
    {
        Id = GetId();
        this.AtomicNumber = atomicNumber;
        this.Symbol = symbol;
        this.Name = name;
        this.AverageAtomicMassString = averageAtomicMassString;
    }
}