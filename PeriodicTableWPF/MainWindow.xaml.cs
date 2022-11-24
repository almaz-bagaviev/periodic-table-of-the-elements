using PeriodicTableWPF.Model;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace PeriodicTableWPF;

public partial class MainWindow : Window
{
    ViewModel viewModel;

    List<StackPanel> nonMetal;
    List<StackPanel> nobleGas;
    List<StackPanel> alkaliMetal;
    List<StackPanel> alkalineEarthMetal;
    List<StackPanel> metalloid;
    List<StackPanel> halogen;
    List<StackPanel> transitionMetal;
    List<StackPanel> lantan;
    List<StackPanel> actin;
    public MainWindow()
    {
        InitializeComponent();
        viewModel = new ViewModel();

        InitElements();
        Paint();
    }

    private void OpenActinides(object sender, MouseButtonEventArgs e)
    {
        viewModel.OpenActinidesWindow();
    }

    private void OpenLantanides(object sender, MouseButtonEventArgs e)
    {
        viewModel.OpenLantanindesWindow();
    }

    private void InitElements()
    {
        nonMetal = new() { H, C, N, O, F, P, S, Se };
        nobleGas = new() { He, Ne, Ar, Kr, Xe, Rn };
        alkaliMetal = new() { Li, Na, K, Rb, Cs, Fr };
        alkalineEarthMetal = new() { Be, Mg, Ca, Sr, Ba, Ra };
        metalloid = new() { B, Si, Ge, As, As, Te, Po, Al, Ga, In, Sn, Tl, Pb, Bi, Sb };
        halogen = new() { F, Cl, Br, I, At };
        transitionMetal = new() { Sc, Ti, V, Cr, Mn, Fe, Co, Ni, Cu, Zn, Y, Zr, Nb, Mo, Tc, Ru,
            Rh, Pd, Ag, Cd, Hf, Ta, W, Re, Os, Ir, Pt, Au, Hg, Rf, Db, Sg, Bh, Hs, Mt, Ds };
        lantan = new() { Lantan };
        actin = new() { Actin };
    }

    private void Paint()
    {
        PaintBackground(nonMetal);
        PaintBackground(nobleGas);
        PaintBackground(alkaliMetal);
        PaintBackground(alkalineEarthMetal);
        PaintBackground(metalloid);
        PaintBackground(nonMetal);
        PaintBackground(halogen);
        PaintBackground(transitionMetal);
        PaintBackground(lantan);
        PaintBackground(actin);
    }

    private void PaintBackground(List<StackPanel> elements)
    {
        foreach (var e in elements)
        {
            if (elements.Contains(H)) e.Background = new SolidColorBrush(Colors.LightSkyBlue);
            else if (elements.Contains(He)) e.Background = new SolidColorBrush(Colors.Silver);
            else if (elements.Contains(Li)) e.Background = new SolidColorBrush(Colors.LightSalmon);
            else if (elements.Contains(Be)) e.Background = new SolidColorBrush(Colors.Tomato);
            else if (elements.Contains(B)) e.Background = new SolidColorBrush(Colors.MediumSeaGreen);
            else if (elements.Contains(F)) e.Background = new SolidColorBrush(Colors.MediumOrchid);
            else if (elements.Contains(Sc)) e.Background = new SolidColorBrush(Colors.SteelBlue);
            else if (elements.Contains(Lantan)) e.Background = new SolidColorBrush(Colors.MediumAquamarine);
            else if (elements.Contains(Actin)) e.Background = new SolidColorBrush(Colors.DarkCyan);
            else e.Background = new SolidColorBrush(Colors.Gold);
        }
    }
}
