namespace PeriodicTable.Models;

public class Repository
{
    public List<ChemicalElement> ChemicalElements { get; set; }
    public List<Lanthanide> Lanthanides { get; set; }
    public List<Actinide> Actinides { get; set; }
    public WebModel GetWebModel { get; set; }

    public Repository()
    {
        Initialize();
        GetWebModel = new();
    }

    private void GetElements()
    {
        #region ChemicalElements

        ChemicalElement hidrogen = new(1, "H", "Водород", 1.008);
        ChemicalElement helium = new(2, "He", "Гелий", 4.003);
        ChemicalElement lithium = new(3, "Li", "Литий", 6.941);
        ChemicalElement beryllium = new(4, "Be", "Беррилий", 9.0122);
        ChemicalElement boron = new(5, "Li", "Бор", 10.811);

        ChemicalElement carbon = new(6, "C", "Углерод", 12.011);
        ChemicalElement nitrogen = new(7, "N", "Азот", 14.007);
        ChemicalElement oxygen = new(8, "O", "Кислород", 15.999);
        ChemicalElement fluorine = new(9, "F", "Фтор", 18.998);
        ChemicalElement neon = new(10, "Ne", "Неон", 20.179);

        ChemicalElement sodium = new(11, "Na", "Натрий", 22.99);
        ChemicalElement magnesium = new(12, "Mg", "Магний", 24.305);
        ChemicalElement aluminium = new(13, "Al", "Аллюминий", 26.98154);
        ChemicalElement silicon = new(14, "Si", "Кремний", 28.086);
        ChemicalElement phosphorus = new(15, "P", "Форфор", 30.974);

        ChemicalElement sulfur = new(16, "S", "Сера", 32.064);
        ChemicalElement chlorine = new(17, "Cl", "Хлор", 35.453);
        ChemicalElement argon = new(18, "Ar", "Аргон", 39.948);
        ChemicalElement potassium = new(19, "K", "Калий", 39.102);
        ChemicalElement calcium = new(20, "Ca", "Кальций", 40.08);

        ChemicalElement scandium = new(21, "Sc", "Скандий", 44.956);
        ChemicalElement titanium = new(22, "Ti", "Титан", 47.956);
        ChemicalElement vanadium = new(23, "V", "Ваннадий", 50.941);
        ChemicalElement chromium = new(24, "Cr", "Хром", 51.996);
        ChemicalElement marganese = new(25, "Mn", "Марганец", 54.938);

        ChemicalElement iron = new(26, "Fe", "Железо", 55.849);
        ChemicalElement cobalt = new(27, "Co", "Кобальт", 58.933);
        ChemicalElement nickel = new(28, "Ni", "Никель", 58.7);
        ChemicalElement copper = new(29, "Cu", "Медь", 63.546);
        ChemicalElement zinc = new(30, "Zn", "Цинк", 65.37);

        ChemicalElement gallium = new(31, "Ga", "Галлий", 69.71);
        ChemicalElement germanium = new(32, "Ge", "Германий", 72.59);
        ChemicalElement arsenic = new(33, "As", "Мышьяк", 74.922);
        ChemicalElement selenium = new(34, "Se", "Селен", 78.96);
        ChemicalElement bromine = new(35, "Br", "Бром", 79.904);

        ChemicalElement krypton = new(36, "Kr", "Криптон", 83.8);
        ChemicalElement rubidium = new(37, "Rb", "Рубидий", 85.468);
        ChemicalElement strontium = new(38, "Sr", "Стронций", 87.62);
        ChemicalElement yttrium = new(39, "Y", "Иттрий", 88.906);
        ChemicalElement zicronium = new(40, "Zr", "Цирконий", 91.22);

        ChemicalElement niobium = new(41, "Nb", "Ниобий", 92.906);
        ChemicalElement molybdenum = new(42, "Mo", "Молибден", 95.94);
        ChemicalElement technetium = new(43, "Tc", "Технеций", "[99]");
        ChemicalElement ruthenium = new(44, "Ru", "Рутений", 101.07);
        ChemicalElement rhodium = new(45, "Rh", "Родий", 102.906);

        ChemicalElement palladium = new(46, "Pd", "Палладий", 106.4);
        ChemicalElement silver = new(47, "Ag", "Серебро", 107.868);
        ChemicalElement cadmium = new(48, "Cd", "Кадмий", 112.41);
        ChemicalElement indium = new(49, "In", "Индий", 114.82);
        ChemicalElement tin = new(50, "Sn", "Олово", 118.69);

        ChemicalElement antimony = new(51, "Sb", "Сурьма", 121.75);
        ChemicalElement tellurium = new(52, "Te", "Теллур", 127.6);
        ChemicalElement iodine = new(53, "I", "Йод", 126.905);
        ChemicalElement xenon = new(54, "Xe", "Ксенон", 131.3);
        ChemicalElement caesium = new(55, "Cs", "Цезий", 132.905);

        ChemicalElement barium = new(56, "Ba", "Барий", 137.34);

        ChemicalElement hafnium = new(72, "Hf", "Гафний", 178.49);
        ChemicalElement tantalum = new(73, "Ta", "Тантал", 180.948);
        ChemicalElement tungsten = new(74, "W", "Вольфрам", 183.85);
        ChemicalElement rhenium = new(75, "Re", "Рений", 186.207);

        ChemicalElement osmium = new(76, "Os", "Осмий", 190.2);
        ChemicalElement iridium = new(77, "Ir", "Иридий", 192.22);
        ChemicalElement platinum = new(78, "Pt", "Платина", 195.09);
        ChemicalElement gold = new(79, "Au", "Золото", 196.967);
        ChemicalElement mercury = new(80, "Hg", "Ртуть", 200.59);

        ChemicalElement thallium = new(81, "Tl", "Таллий", 204.37);
        ChemicalElement lead = new(82, "Pb", "Свинец", 207.19);
        ChemicalElement bismuth = new(83, "Bi", "Висмут", 186.207);
        ChemicalElement polonium = new(84, "Po", "Полоний", "[210]");
        ChemicalElement astatine = new(85, "At", "Астат", "[210]");

        ChemicalElement radon = new(86, "Rn", "Радон", "[222]");
        ChemicalElement francium = new(87, "Fr", "Франций", "[223]");
        ChemicalElement radium = new(88, "Ra", "Радий", "[226]");

        ChemicalElement rutherfordium = new(104, "Rf", "Резерфордий", "[261]");
        ChemicalElement dubnium = new(105, "Db", "Дубний", "[262]");

        ChemicalElement seaborgium = new(106, "Sg", "Сиборгий", "[263]");
        ChemicalElement bohrium = new(107, "Bh", "Борий", "[262]");
        ChemicalElement hassium = new(108, "Hs", "Хассий", "[265]");

        #endregion

        this.ChemicalElements = new()
        {
            hidrogen, helium, lithium, beryllium, boron, carbon, nitrogen, oxygen, fluorine, neon,
            sodium, magnesium, aluminium, silicon, phosphorus, sulfur, chlorine, argon, potassium, calcium,
            scandium, titanium, vanadium, chromium, marganese, iron, cobalt, nickel, copper, zinc,
            gallium, germanium, arsenic, selenium, bromine, krypton, rubidium, strontium, yttrium, zicronium,
            niobium, molybdenum, technetium, ruthenium, rhodium, palladium, silver, cadmium, indium, tin,
            antimony, tellurium, iodine, xenon, caesium, barium, hafnium, tantalum, tungsten, rhenium,
            osmium, iridium, platinum, gold, mercury, thallium, lead, bismuth, polonium, astatine,
            radon, francium, radium, rutherfordium, dubnium, seaborgium, bohrium, hassium
        };
    }

    private void GetLanthanides()
    {
        #region Lanthanides

        Lanthanide lanthanum = new(57, "La", "Лантан", 138.906);
        Lanthanide cerium = new(58, "Ce", "Церий", 140.12);
        Lanthanide praseodymium = new(59, "Pr", "Празеодим", 140.908);
        Lanthanide neodymium = new(60, "Nd", "Неодим", 144.24);

        Lanthanide promethium = new(61, "Pm", "Прометий", "[145]");
        Lanthanide samarium = new(62, "Sm", "Самарий", 150.4);
        Lanthanide europium = new(63, "Eu", "Европий", 151.96);
        Lanthanide gadolinium = new(64, "Gd", "Гадолиний", 157.25);
        Lanthanide teribium = new(65, "Tb", "Тербий", 158.926);

        Lanthanide disprosium = new(66, "Dy", "Диспрозий", 162.5);
        Lanthanide holmium = new(67, "Ho", "Гольмий", 164.93);
        Lanthanide erbium = new(68, "Er", "Эрбий", 167.26);
        Lanthanide thulium = new(69, "Tm", "Туллий", 168.934);
        Lanthanide ytterbium = new(70, "Yb", "Иттербий", 173.04);
        Lanthanide lutetium = new(71, "Lu", "Лютеций", 174.97);

        #endregion

        this.Lanthanides = new()
        {
            lanthanum, cerium, praseodymium, neodymium, promethium, samarium, europium, gadolinium, teribium,
            disprosium, holmium, erbium, thulium, ytterbium, lutetium
        };
    }

    private void GetActinides()
    {
        #region Actinides

        Actinide actinium = new(89, "Ac", "Актиний", "[227]");
        Actinide thorium = new(90, "Th", "Торрий", 232.038);
        Actinide protactinium = new(91, "Pa", "Протактиний", "[231]");
        Actinide uranium = new(92, "U", "Уран", 238.29);
        Actinide neptunium = new(93, "Np", "Нептуний", "[237]");
        Actinide plutonium = new(94, "Pu", "Плутоний", "[244]");
        Actinide americium = new(95, "Am", "Америций", "[243]");

        Actinide curium = new(96, "Cm", "Кюрий", "[247]");
        Actinide berkelium = new(97, "Bk", "Берклий", "[247]");
        Actinide californium = new(98, "Cf", "Калифорний", "[251]");
        Actinide einstenium = new(99, "Es", "Эйнштений", "[254]");
        Actinide fermium = new(100, "Fm", "Фермий", "[257]");

        Actinide mendelevium = new(101, "Md", "Менделевий", "[258]");
        Actinide nobelium = new(102, "No", "Нобелий", "[259]");
        Actinide lawrencium = new(103, "Lr", "Лоуренсий", "[260]");

        #endregion

        this.Actinides = new()
        {
            actinium, thorium, protactinium, uranium, neptunium, plutonium, americium,
            curium, berkelium, californium, einstenium, fermium, mendelevium, nobelium, lawrencium
        };

    }

    private void Initialize()
    {
        GetElements();
        GetLanthanides();
        GetActinides();
    }
}
