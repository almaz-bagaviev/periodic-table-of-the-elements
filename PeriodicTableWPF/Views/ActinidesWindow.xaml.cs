using System.Collections;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace PeriodicTableWPF.Views;

public partial class ActinidesWindow : Window
{
    List<StackPanel> Actinides;

    public ActinidesWindow()
    {
        InitializeComponent();
        InitElements();
        Print();
    }

    private void InitElements()
    {
        Actinides = new() { Ac, Th, Pa, U, Np, Pu, Am, Cm, Bk, Cf, Es, Fm, Md, No, Lr };
    }

    private void Print()
    {
        foreach (StackPanel e in Actinides)
        {
            e.Background = new SolidColorBrush(Colors.DarkCyan);
        }
    }
}
