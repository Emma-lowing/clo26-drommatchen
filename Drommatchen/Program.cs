// TODO: Skapa minst 2 spelare
// Spelare spelare1 = new Spelare("Namn", nummer, "Position");
// Spelare spelare2 = new Spelare(...);

// TODO: Skapa 1 match
// Match match = new Match("Hemmalag", "Bortalag", "Datum");

// TODO: Anropa match.Presentera()

// TODO: Anropa match.AnnounceraMålskytt() med båda spelarna


class Program
{
    static void Main()
    {
        Spelare jamieTart = new Spelare("Jamie Tart", 10, "Forward",0);
        Spelare samObisanya = new Spelare("Sam Obisanya", 24, "Forward",0);

        Match match = new Match("Richmond", "Manchester City", "2026-11-10");

        match.Presentera();
        match.AnnounceraMålskytt(jamieTart);
        match.AnnounceraMålskytt(samObisanya);


    }
}