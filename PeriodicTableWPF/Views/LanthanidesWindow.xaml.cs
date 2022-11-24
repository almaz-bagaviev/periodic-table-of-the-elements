using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace PeriodicTableWPF.Views;

public partial class LanthanidesWindow : Window
{
    List<StackPanel> Lanthanides;

    public LanthanidesWindow()
    {
        InitializeComponent();
        InitElements();
        Print();
    }
    private void InitElements()
    {
        Lanthanides = new() { La, Ce, Pr, Nd, Pm, Sm, Eu, Gd, Tb, Dy, Ho, Er, Tm, Yb, Lu };
    }

    private void Print()
    {
        foreach (StackPanel e in Lanthanides)
        {
            e.Background = new SolidColorBrush(Colors.MediumAquamarine);
        }
    }
}
