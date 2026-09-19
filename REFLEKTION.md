# Reflektion

**Namn:** Emma Löwing 
**Kurs:**  Grundläggande OOP i C#
**Uppgift:**  Drömmatchen
**Datum:**  26-09-19

---

> Den här reflektionen är obligatorisk och lämnas in individuellt — även om uppgiften gjordes i grupp.  
> Det finns inga rätta eller fel svar. Skriv vad du faktiskt tyckte och upplevde.

---

## Vad var svårast att lösa?

*Var fastnade du? Vad tog längre tid än du trodde — och hur kom du vidare?*

> Det svåraste var att förstå hur jag skulle få de olika delarna av koden att samarbeta, framför allt hur klasserna Spelare och Match kunde använda information från varandra. Jag fastnade bland annat när jag insåg att jag inte kunde använda fälten från Spelare direkt i Match eftersom de var privata. Jag förstod att parametern Spelare spelare var något som jag kunde använda mig av men jag behövde bolla mina idéer med ChatGPT (förpromptad som lärare så att jag inte skulle få svaret direkt) och jag kom fram till att jag kunde använda spelarens properties, till exempel spelare.Namn. Efter detta förstod jag bättre hur klasser kan samarbeta utan att de privata fälten behöver vara åtkomliga utifrån. Jag fick också en bättre förståelse för vad en parameter gör och hur ett objekt kan skickas in till en metod och sedan användas där.

---

## Om du fick göra om det — vad hade du gjort annorlunda?

*Tänk på din lösning, din struktur, eller hur ni jobbade. Vad skulle du ändra?*

> Om jag skulle göra om uppgiften skulle jag hoppa över delen där jag först lade till int mål som en parameter i konstruktorn, för att sedan ändra lösningen till att _mål = 0 sätts direkt i konstruktorn. Jag skulle även vilja använda mig av en lista för att på ett mer effektivt sätt jämföra spelarobjektens antal mål med varandra. Det hade gjort lösningen smidigare om programmet hade innehållit fler än två spelare.


## Varför ÄrMatchhjälte returnerar bool istället för att skriva ut direkt?
> ÄrMatchhjälte() returnerar en bool eftersom metoden ska ta reda på om en spelare är matchhjälte och lämna tillbaka svaret som true eller false. Här använder vi return, som skickar tillbaka svaret så att det kan användas på andra ställen i programmet. Om jag istället hade använt Console.WriteLine() i metoden hade resultatet bara skrivits ut i konsolen. Fördelen med att använda return är att jag istället kan bestämma i Main vad jag vill göra med resultatet, till exempel skriva ut det med Console.WriteLine().

