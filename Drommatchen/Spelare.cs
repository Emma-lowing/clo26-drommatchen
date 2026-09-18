public class Spelare
{
    // Privata fält
    private string _namn;
    private int _nummer;
    private string _position;

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

    // Konstruktor
    public Spelare(string namn, int nummer, string position)
    {
        _namn = namn;
        _nummer = nummer;
        _position = position;
    }
}
