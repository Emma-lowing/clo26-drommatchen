# Rapport

**Kurs:** Grundläggande OOP i C#  
**Uppgift:** Drömmatchen  
**Grupp:**  
**Datum:**  2026-09-19
**GitHub:**  https://github.com/Emma-lowing/clo26-drommatchen?utm_source=chatgpt.com

---

## Gruppmedlemmar

| Namn | Lämnade in |
|------|-----------|
| Emma Löwing | Zip + RAPPORT.md + REFLEKTION.md |
---

## G — Hur vi löste uppgiften

> Förklara kortfattat hur du löste varje G-krav. En till tre meningar per punkt räcker.  
> Skriv med egna ord — kopiera inte uppgiftsbeskrivningen.

### Klasserna

> Jag skapade klasserna Spelare och Match. I "Spelare" fyllde jag i allt som var relevant för att skapa spelarobjekt. Dvs namn, nummer, position och mål. I klassen "Match" fyllde jag i allt som var relevant för skapandet av matchobjekt. Dvs hemmalag, bortalag och datum. I båda klasserna skapade jag privata fält, properties samt konstruktor. I klassen match skapade jag även två metoder. En metod för att prsentera matchen och en metod för att announcera att en spelare gjort mål.

### Metoderna

> I klassen Match skapade jag metoderna Presentera() och AnnounceraMålskytt(). Den första metoden jag skapade var "Presentera()". Det gick bra. Jag använde Console.Writeline för och sedan en string interpolation för att kunna skriva text och lägga in relevanta variabler. När jag gjorde AnnounceraMålskytt() insåg jag att jag inte kunde använda spelarens privata fält direkt eftersom de ligger i klassen Spelare. Jag förstod då att genom att skriva Spelare spelare kunde metoden ta emot ett Spelare-objekt och komma åt den aktuella spelarens properties, till exempel spelare.Nummer och spelare.Namn.



### Main()

> I Main skapade jag objekten Spelare jamieTart, Spelare samObisanya samt Match match. Jag anropade mina metoder för att få programmet att göra saker med objekten jag skapat, som att presentera matchen och announcera målskytt.  

### Git

> Jag planerade mitt kodande och delade upp processen i mindre delar. Efter varje sådan del använde jag git add, gjorde jag en git commit -m och sedan git push för att säkerställa att jag sparade mitt arbete på git hub. Jag skrev informerande meddelanden varje gång för att det ska vara lätt att följa arbetsprocessen. Jag var även nogrann med att alltid kolla git status innan jag använde git commit eller git push. Detta för att säkerställa att allt var i sin ordning. 

### Kodkvalitet

> För att få en tydlig kod gav jag tydliga namn på klasser, variabler, properties och metoder. Jag skrev in rubriker på de platser koden kunde vara svår att förstå samt att jag använde string interpolation med måsvingar för att skapa tydliga och lättlästa utskrifter. 

---

## VG — Motivering

> Fyll i det här avsnittet om du siktar på VG. Lämna tomt = G-bedömning.

### Vad vi lade till

> För VG lade jag till möjligheten att hålla koll på hur många mål varje spelare har gjort. Jag lade till ett privat fält _mål och en property Mål i klassen Spelare. Jag skapade även metoden ÖkaMål() som gör att spelarens antal mål ökar varje gång spelaren används i AnnounceraMålskytt(). Till sist skapade jag metoden ÄrMatchhjälte() som jämför spelarnas antal mål och returnerar true eller false beroende på om spelaren har gjort flest mål.

### Varför vi löste det såhär

> Jag valde att låta varje spelare börja med 0 mål eftersom målen ska registreras under matchens gång. Eftersom _mål är privat ville jag inte ändra det direkt från klassen Match, utan skapade istället metoden ÖkaMål() i Spelare. På så sätt ansvarar Spelare själv för att ändra sitt antal mål. Jag lät ÄrMatchhjälte() returnera en bool istället för att skriva ut resultatet direkt. Då kan metoden bara avgöra om spelaren är matchhjälte eller inte, medan Main bestämmer vad som ska göras med resultatet.

---

## Git-logg

Klistra in utskriften från `git log --oneline` här:

```
$ git log --oneline
b3f2788 (HEAD -> main, origin/main, origin/HEAD) Uppdaterade målhanteringen och ÄrMatchhjälte så att spelarnas mål jämförs
cc120bb Uppdaterade privata fälten, properties och konstruktorn genom att lägga till mål i spelare. Uppdaterade även objekten genom att lägga till argumentet mål
5380fb3 Skapade objekt samt anropade metoder i Program. La till en förtydligande kommentar i Match
729d9c2 Fyllde i Properties, konstruktor samt skapade metoderna Presentera() och AnnounceraMålskytt(Spelare spelare) i class Match
fbc1a14 fyllde i properties och konstruktor i class Spelare
7ff003f Add .gitignore
34de7d5 refactor: gör property-kroppar tomma — studerande implementerar själva
66f4917 init: starterrepo för Drömmatchen (Inlämning 1)

```
