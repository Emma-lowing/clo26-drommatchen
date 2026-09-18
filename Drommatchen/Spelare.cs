public class Spelare
{
    // Privata fält
    private string _namn;
    private int _nummer;
    private string _position;
    private int _mål;


    // Properties — publik get, privat set
    public string Namn
    {
       get { return _namn; }
        private set
        {
            _namn = value;
        }
    }

    public int Nummer
    {
        get { return _nummer; }
        private set
        {
            _nummer = value;
        }
    }

    public string Position
    {
        get { return _position; }
        private set
        {
            _position = value;
        }
    }
    public int Mål
    {
        get { return _mål; }
        private set
        {
            _mål = value;
        }

    }

    // Konstruktor
    public Spelare(string namn, int nummer, string position, int mål)
    {
        _namn = namn;
        _nummer = nummer;
        _position = position;
        _mål = mål;
    }
}
