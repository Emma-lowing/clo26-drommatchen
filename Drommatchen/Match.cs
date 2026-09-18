public class Match
{
    // Privata fält
    private string _hemmalag;
    private string _bortalag;
    private string _datum;

    // Properties — publik get, privat set
    public string Hemmalag
    {
        get { return _hemmalag; }
        private set
        {
            _hemmalag = value;
        }

    }

    public string Bortalag
    {
       get { return _bortalag; }
        private set
        {
            _bortalag = value;
        }
    }

    public string Datum
    {
        get { return _datum; }
        private set
        {
            _datum = value;
        }
    }

    // Konstruktor
    public Match(string hemmalag, string bortalag, string datum)
    {
        _hemmalag = hemmalag;
        _bortalag = bortalag;
        _datum = datum;

    }

    // Metod 1: skriv ut matchens lag och datum
    public void Presentera()
    {
        Console.WriteLine($"Drömlagen {_hemmalag} vs {_bortalag} - {_datum}");
        Console.WriteLine(); //För att det ska se snyggare ut 
    }

    // Metod 2: skriv ut spelarens namn, nummer och position
    public void AnnounceraMålskytt(Spelare spelare)
    {
        Console.WriteLine($"MÅÅÅL! #{spelare.Nummer} {spelare.Namn} ({spelare.Position})");
    }
}
