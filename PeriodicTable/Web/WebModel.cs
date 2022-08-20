namespace PeriodicTable.Web;

public class WebModel
{
    public List<Link> LinkMainElements { get; set; }
    public List<Link> LinkLanthanides { get; set; }
    public List<Link> LinkActinides { get; set; }
    public string LinkName { get; set; }

    public WebModel()
    {
        GetLinksElements();
        GetLinksLanthanides();
        GetLinkActinides();
    }

    private void GetLinksElements()
    {
        LinkMainElements = new()
        {
            new Link(1, @"https://ru.wikipedia.org/wiki/%D0%92%D0%BE%D0%B4%D0%BE%D1%80%D0%BE%D0%B4"),
            new Link(2, @"https://ru.wikipedia.org/wiki/%D0%93%D0%B5%D0%BB%D0%B8%D0%B9"),
            new Link(3, @"https://ru.wikipedia.org/wiki/%D0%9B%D0%B8%D1%82%D0%B8%D0%B9"),
            new Link(4, @"https://ru.wikipedia.org/wiki/%D0%91%D0%B5%D1%80%D0%B8%D0%BB%D0%BB%D0%B8%D0%B9"),
            new Link(5, @"https://ru.wikipedia.org/wiki/%D0%91%D0%BE%D1%80_(%D1%8D%D0%BB%D0%B5%D0%BC%D0%B5%D0%BD%D1%82)"),
            new Link(6, @"https://ru.wikipedia.org/wiki/%D0%A3%D0%B3%D0%BB%D0%B5%D1%80%D0%BE%D0%B4"),
            new Link(7, @"https://ru.wikipedia.org/wiki/%D0%90%D0%B7%D0%BE%D1%82"),
            new Link(8, @"https://ru.wikipedia.org/wiki/%D0%9A%D0%B8%D1%81%D0%BB%D0%BE%D1%80%D0%BE%D0%B4"),
            new Link(9, @"https://ru.wikipedia.org/wiki/%D0%A4%D1%82%D0%BE%D1%80"),
            new Link(10, @"https://ru.wikipedia.org/wiki/%D0%9D%D0%B5%D0%BE%D0%BD"),
            new Link(11, @"https://ru.wikipedia.org/wiki/%D0%9D%D0%B0%D1%82%D1%80%D0%B8%D0%B9"),
            new Link(12, @"https://ru.wikipedia.org/wiki/%D0%9C%D0%B0%D0%B3%D0%BD%D0%B8%D0%B9"),
            new Link(13, @"https://ru.wikipedia.org/wiki/%D0%90%D0%BB%D1%8E%D0%BC%D0%B8%D0%BD%D0%B8%D0%B9"),
            new Link(14, @"https://ru.wikipedia.org/wiki/%D0%9A%D1%80%D0%B5%D0%BC%D0%BD%D0%B8%D0%B9"),
            new Link(15, @"https://ru.wikipedia.org/wiki/%D0%A4%D0%BE%D1%81%D1%84%D0%BE%D1%80"),
            new Link(16, @"https://ru.wikipedia.org/wiki/%D0%A1%D0%B5%D1%80%D0%B0"),
            new Link(17, @"https://ru.wikipedia.org/wiki/%D0%A5%D0%BB%D0%BE%D1%80"),
            new Link(18, @"https://ru.wikipedia.org/wiki/%D0%90%D1%80%D0%B3%D0%BE%D0%BD"),
            new Link(19, @"https://ru.wikipedia.org/wiki/%D0%9A%D0%B0%D0%BB%D0%B8%D0%B9"),
            new Link(20, @"https://ru.wikipedia.org/wiki/%D0%9A%D0%B0%D0%BB%D1%8C%D1%86%D0%B8%D0%B9"),

            new Link(21, @"https://ru.wikipedia.org/wiki/%D0%A1%D0%BA%D0%B0%D0%BD%D0%B4%D0%B8%D0%B9"),
            new Link(22, @"https://ru.wikipedia.org/wiki/%D0%A2%D0%B8%D1%82%D0%B0%D0%BD_(%D1%8D%D0%BB%D0%B5%D0%BC%D0%B5%D0%BD%D1%82)"),
            new Link(23, @"https://ru.wikipedia.org/wiki/%D0%92%D0%B0%D0%BD%D0%B0%D0%B4%D0%B8%D0%B9"),
            new Link(24, @"https://ru.wikipedia.org/wiki/%D0%A5%D1%80%D0%BE%D0%BC"),
            new Link(25, @"https://ru.wikipedia.org/wiki/%D0%9C%D0%B0%D1%80%D0%B3%D0%B0%D0%BD%D0%B5%D1%86"),
            new Link(26, @"https://ru.wikipedia.org/wiki/%D0%96%D0%B5%D0%BB%D0%B5%D0%B7%D0%BE"),
            new Link(27, @"https://ru.wikipedia.org/wiki/%D0%9A%D0%BE%D0%B1%D0%B0%D0%BB%D1%8C%D1%82"),
            new Link(28, @"https://ru.wikipedia.org/wiki/%D0%9D%D0%B8%D0%BA%D0%B5%D0%BB%D1%8C"),
            new Link(29, @"https://ru.wikipedia.org/wiki/%D0%9C%D0%B5%D0%B4%D1%8C"),
            new Link(30, @"https://ru.wikipedia.org/wiki/%D0%A6%D0%B8%D0%BD%D0%BA"),

            new Link(31, @"https://ru.wikipedia.org/wiki/%D0%93%D0%B0%D0%BB%D0%BB%D0%B8%D0%B9"),
            new Link(32, @"https://ru.wikipedia.org/wiki/%D0%93%D0%B5%D1%80%D0%BC%D0%B0%D0%BD%D0%B8%D0%B9"),
            new Link(33, @"https://ru.wikipedia.org/wiki/%D0%9C%D1%8B%D1%88%D1%8C%D1%8F%D0%BA"),
            new Link(34, @"https://ru.wikipedia.org/wiki/%D0%A1%D0%B5%D0%BB%D0%B5%D0%BD"),
            new Link(35, @"https://ru.wikipedia.org/wiki/%D0%91%D1%80%D0%BE%D0%BC"),
            new Link(36, @"https://ru.wikipedia.org/wiki/%D0%9A%D1%80%D0%B8%D0%BF%D1%82%D0%BE%D0%BD"),
            new Link(37, @"https://ru.wikipedia.org/wiki/%D0%A0%D1%83%D0%B1%D0%B8%D0%B4%D0%B8%D0%B9"),
            new Link(38, @"https://ru.wikipedia.org/wiki/%D0%A1%D1%82%D1%80%D0%BE%D0%BD%D1%86%D0%B8%D0%B9"),
            new Link(39, @"https://ru.wikipedia.org/wiki/%D0%98%D1%82%D1%82%D1%80%D0%B8%D0%B9"),
            new Link(40, @"https://ru.wikipedia.org/wiki/%D0%A6%D0%B8%D1%80%D0%BA%D0%BE%D0%BD%D0%B8%D0%B9"),

            new Link(41, @"https://ru.wikipedia.org/wiki/%D0%9D%D0%B8%D0%BE%D0%B1%D0%B8%D0%B9"),
            new Link(42, @"https://ru.wikipedia.org/wiki/%D0%9C%D0%BE%D0%BB%D0%B8%D0%B1%D0%B4%D0%B5%D0%BD"),
            new Link(43, @"https://ru.wikipedia.org/wiki/%D0%A2%D0%B5%D1%85%D0%BD%D0%B5%D1%86%D0%B8%D0%B9"),
            new Link(44, @"https://ru.wikipedia.org/wiki/%D0%A0%D1%83%D1%82%D0%B5%D0%BD%D0%B8%D0%B9"),
            new Link(45, @"https://ru.wikipedia.org/wiki/%D0%A0%D0%BE%D0%B4%D0%B8%D0%B9"),
            new Link(46, @"https://ru.wikipedia.org/wiki/%D0%9F%D0%B0%D0%BB%D0%BB%D0%B0%D0%B4%D0%B8%D0%B9"),
            new Link(47, @"https://ru.wikipedia.org/wiki/%D0%A1%D0%B5%D1%80%D0%B5%D0%B1%D1%80%D0%BE"),
            new Link(48, @"https://ru.wikipedia.org/wiki/%D0%9A%D0%B0%D0%B4%D0%BC%D0%B8%D0%B9"),
            new Link(49, @"https://ru.wikipedia.org/wiki/%D0%98%D0%BD%D0%B4%D0%B8%D0%B9"),
            new Link(50, @"https://ru.wikipedia.org/wiki/%D0%9E%D0%BB%D0%BE%D0%B2%D0%BE"),

            new Link(51, @"https://ru.wikipedia.org/wiki/%D0%A1%D1%83%D1%80%D1%8C%D0%BC%D0%B0"),
            new Link(52, @"https://ru.wikipedia.org/wiki/%D0%A2%D0%B5%D0%BB%D0%BB%D1%83%D1%80"),
            new Link(53, @"https://ru.wikipedia.org/wiki/%D0%98%D0%BE%D0%B4"),
            new Link(54, @"https://ru.wikipedia.org/wiki/%D0%9A%D1%81%D0%B5%D0%BD%D0%BE%D0%BD"),
            new Link(55, @"https://ru.wikipedia.org/wiki/%D0%A6%D0%B5%D0%B7%D0%B8%D0%B9"),
            new Link(56, @"https://ru.wikipedia.org/wiki/%D0%91%D0%B0%D1%80%D0%B8%D0%B9"),

            new Link(72, @"https://ru.wikipedia.org/wiki/%D0%93%D0%B0%D1%84%D0%BD%D0%B8%D0%B9"),
            new Link(73, @"https://ru.wikipedia.org/wiki/%D0%A2%D0%B0%D0%BD%D1%82%D0%B0%D0%BB_(%D1%8D%D0%BB%D0%B5%D0%BC%D0%B5%D0%BD%D1%82)"),
            new Link(74, @"https://ru.wikipedia.org/wiki/%D0%92%D0%BE%D0%BB%D1%8C%D1%84%D1%80%D0%B0%D0%BC"),
            new Link(75, @"https://ru.wikipedia.org/wiki/%D0%A0%D0%B5%D0%BD%D0%B8%D0%B9"),
            new Link(76, @"https://ru.wikipedia.org/wiki/%D0%9E%D1%81%D0%BC%D0%B8%D0%B9"),
            new Link(77, @"https://ru.wikipedia.org/wiki/%D0%98%D1%80%D0%B8%D0%B4%D0%B8%D0%B9"),
            new Link(78, @"https://ru.wikipedia.org/wiki/%D0%9F%D0%BB%D0%B0%D1%82%D0%B8%D0%BD%D0%B0"),
            new Link(79, @"https://ru.wikipedia.org/wiki/%D0%97%D0%BE%D0%BB%D0%BE%D1%82%D0%BE"),
            new Link(80, @"https://ru.wikipedia.org/wiki/%D0%A0%D1%82%D1%83%D1%82%D1%8C"),

            new Link(81, @"https://ru.wikipedia.org/wiki/%D0%A2%D0%B0%D0%BB%D0%BB%D0%B8%D0%B9"),
            new Link(82, @"https://ru.wikipedia.org/wiki/%D0%A1%D0%B2%D0%B8%D0%BD%D0%B5%D1%86"),
            new Link(83, @"https://ru.wikipedia.org/wiki/%D0%92%D0%B8%D1%81%D0%BC%D1%83%D1%82"),
            new Link(84, @"https://ru.wikipedia.org/wiki/%D0%9F%D0%BE%D0%BB%D0%BE%D0%BD%D0%B8%D0%B9"),
            new Link(85, @"https://ru.wikipedia.org/wiki/%D0%90%D1%81%D1%82%D0%B0%D1%82"),
            new Link(86, @"https://ru.wikipedia.org/wiki/%D0%A0%D0%B0%D0%B4%D0%BE%D0%BD"),
            new Link(87, @"https://ru.wikipedia.org/wiki/%D0%A4%D1%80%D0%B0%D0%BD%D1%86%D0%B8%D0%B9"),
            new Link(88, @"https://ru.wikipedia.org/wiki/%D0%A0%D0%B0%D0%B4%D0%B8%D0%B9"),

            new Link(104, @"https://ru.wikipedia.org/wiki/%D0%A0%D0%B5%D0%B7%D0%B5%D1%80%D1%84%D0%BE%D1%80%D0%B4%D0%B8%D0%B9"),
            new Link(105, @"https://ru.wikipedia.org/wiki/%D0%94%D1%83%D0%B1%D0%BD%D0%B8%D0%B9"),
            new Link(106, @"https://ru.wikipedia.org/wiki/%D0%A1%D0%B8%D0%B1%D0%BE%D1%80%D0%B3%D0%B8%D0%B9"),
            new Link(107, @"https://ru.wikipedia.org/wiki/%D0%91%D0%BE%D1%80%D0%B8%D0%B9"),
            new Link(108, @"https://ru.wikipedia.org/wiki/%D0%A5%D0%B0%D1%81%D1%81%D0%B8%D0%B9"),
        };
    }

    private void GetLinksLanthanides()
    {
        LinkLanthanides = new()
        {
            new Link(57, @"https://ru.wikipedia.org/wiki/%D0%9B%D0%B0%D0%BD%D1%82%D0%B0%D0%BD"),
            new Link(58, @"https://ru.wikipedia.org/wiki/%D0%A6%D0%B5%D1%80%D0%B8%D0%B9"),
            new Link(59, @"https://ru.wikipedia.org/wiki/%D0%9F%D1%80%D0%B0%D0%B7%D0%B5%D0%BE%D0%B4%D0%B8%D0%BC"),
            new Link(60, @"https://ru.wikipedia.org/wiki/%D0%9D%D0%B5%D0%BE%D0%B4%D0%B8%D0%BC"),

            new Link(61, @"https://ru.wikipedia.org/wiki/%D0%9F%D1%80%D0%BE%D0%BC%D0%B5%D1%82%D0%B8%D0%B9"),
            new Link(62, @"https://ru.wikipedia.org/wiki/%D0%A1%D0%B0%D0%BC%D0%B0%D1%80%D0%B8%D0%B9"),
            new Link(63, @"https://ru.wikipedia.org/wiki/%D0%95%D0%B2%D1%80%D0%BE%D0%BF%D0%B8%D0%B9"),
            new Link(64, @"https://ru.wikipedia.org/wiki/%D0%93%D0%B0%D0%B4%D0%BE%D0%BB%D0%B8%D0%BD%D0%B8%D0%B9"),
            new Link(65, @"https://ru.wikipedia.org/wiki/%D0%A2%D0%B5%D1%80%D0%B1%D0%B8%D0%B9"),
            new Link(66, @"https://ru.wikipedia.org/wiki/%D0%94%D0%B8%D1%81%D0%BF%D1%80%D0%BE%D0%B7%D0%B8%D0%B9"),
            new Link(67, @"https://ru.wikipedia.org/wiki/%D0%93%D0%BE%D0%BB%D1%8C%D0%BC%D0%B8%D0%B9"),
            new Link(68, @"https://ru.wikipedia.org/wiki/%D0%AD%D1%80%D0%B1%D0%B8%D0%B9"),
            new Link(69, @"https://ru.wikipedia.org/wiki/%D0%A2%D1%83%D0%BB%D0%B8%D0%B9"),
            new Link(70, @"https://ru.wikipedia.org/wiki/%D0%98%D1%82%D1%82%D0%B5%D1%80%D0%B1%D0%B8%D0%B9"),
            new Link(71, @"https://ru.wikipedia.org/wiki/%D0%9B%D1%8E%D1%82%D0%B5%D1%86%D0%B8%D0%B9"),
        };
    }

    private void GetLinkActinides()
    {
        LinkActinides = new()
        {
            new Link(89, @"https://ru.wikipedia.org/wiki/%D0%90%D0%BA%D1%82%D0%B8%D0%BD%D0%B8%D0%B9"),
            new Link(90, @"https://ru.wikipedia.org/wiki/%D0%A2%D0%BE%D1%80%D0%B8%D0%B9"),
            new Link(91, @"https://ru.wikipedia.org/wiki/%D0%9F%D1%80%D0%BE%D1%82%D0%B0%D0%BA%D1%82%D0%B8%D0%BD%D0%B8%D0%B9"),
            new Link(92, @"https://ru.wikipedia.org/wiki/%D0%A3%D1%80%D0%B0%D0%BD_(%D1%8D%D0%BB%D0%B5%D0%BC%D0%B5%D0%BD%D1%82)"),
            new Link(93, @"https://ru.wikipedia.org/wiki/%D0%9D%D0%B5%D0%BF%D1%82%D1%83%D0%BD%D0%B8%D0%B9"),
            new Link(94, @"https://ru.wikipedia.org/wiki/%D0%9F%D0%BB%D1%83%D1%82%D0%BE%D0%BD%D0%B8%D0%B9"),
            new Link(95, @"https://ru.wikipedia.org/wiki/%D0%90%D0%BC%D0%B5%D1%80%D0%B8%D1%86%D0%B8%D0%B9"),
            new Link(96, @"https://ru.wikipedia.org/wiki/%D0%9A%D1%8E%D1%80%D0%B8%D0%B9"),
            new Link(97, @"https://ru.wikipedia.org/wiki/%D0%91%D0%B5%D1%80%D0%BA%D0%BB%D0%B8%D0%B9"),
            new Link(98, @"https://ru.wikipedia.org/wiki/%D0%9A%D0%B0%D0%BB%D0%B8%D1%84%D0%BE%D1%80%D0%BD%D0%B8%D0%B9"),
            new Link(99, @"https://ru.wikipedia.org/wiki/%D0%AD%D0%B9%D0%BD%D1%88%D1%82%D0%B5%D0%B9%D0%BD%D0%B8%D0%B9"),

            new Link(100, @"https://ru.wikipedia.org/wiki/%D0%A4%D0%B5%D1%80%D0%BC%D0%B8%D0%B9"),
            new Link(101, @"https://ru.wikipedia.org/wiki/%D0%9C%D0%B5%D0%BD%D0%B4%D0%B5%D0%BB%D0%B5%D0%B2%D0%B8%D0%B9"),
            new Link(102, @"https://ru.wikipedia.org/wiki/%D0%9D%D0%BE%D0%B1%D0%B5%D0%BB%D0%B8%D0%B9"),
            new Link(103, @"https://ru.wikipedia.org/wiki/%D0%9B%D0%BE%D1%83%D1%80%D0%B5%D0%BD%D1%81%D0%B8%D0%B9"),
        };
    }

    public string URL(int number)
    {
        string linkName = string.Empty;

        for (int i = 0; i < LinkMainElements.Count; i++)
        {
            if (number == LinkMainElements[i].AtomicNumber)
            {
                linkName = LinkMainElements[i].Url;
            }
        }
        return linkName;
    }

    public string UrlLanthan(int number)
    {
        string linkName = string.Empty;

        for (int i = 0; i < LinkLanthanides.Count; i++)
        {
            if (number == LinkLanthanides[i].AtomicNumber)
            {
                linkName = LinkLanthanides[i].Url;
            }
        }
        return linkName;
    }

    public string UrlActin(int number)
    {
        string linkName = string.Empty;

        for (int i = 0; i < LinkActinides.Count; i++)
        {
            if (number == LinkActinides[i].AtomicNumber)
            {
                linkName = LinkActinides[i].Url;
            }
        }
        return linkName;
    }
}
