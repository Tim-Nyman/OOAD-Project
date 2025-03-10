# OOAD Uppgift

Uppgiften gick ut på att skapa en förenklad lösning för en bowlinghall att kunna hantera medlemmar, banor, tävlingar och matcher.
Fokus ligger på att förstå och använda kravhantering, olika visualiseringar samt objektorienterad programmering i C#.

Jag försökte mig på att använda Facade Pattern (GameService.cs) och Singleton Pattern (DataContext.cs). Med dessa i åtanke så byggde jag en simpel applikation som registrerar spelare till en MSSQL databas där de sedan uppdaterar deras vinster och utifrån detta skapar ett highscore. Matcherna i sig är bara en random generator, inga regler är involverade i vem som vinner förutom högst nummer, detta för att hålla det enkelt och kunna fokusera på uppgiften i sig (uppdelning av klasser, följa SOLID-principerna och användning av design patterns).


## Kravspecifikation:
Use Case-beskrivningar för de viktigaste användningsfallen (t.ex. registrera medlem, skapa match, registrera resultat). Välj en av dessa.
Ett klassdiagram med de viktigaste klasserna och deras relationer.
Ett workflow diagram som visar flödet under en match.

## Kodprojekt - En förenklad konsolapplikation i C# där man kan:

Registrera medlemmar.

Skapa en match mellan två spelare.

Bestämma vinnaren av en match.

Minst ett designmönster ska användas och kommenteras i koden (t.ex. Factory Pattern för att skapa spelare).

Databas (kan vara en enkel SQLite eller filbaserad lagring).

Att kunna lagra medlemmar eller matchresultat. Håll det enkelt!

Loggning av systemets förlopp (exempelvis med en logging-provider i .NET eller en hjälpklass – se SingletonLogger).

Wireframe för hur ett enkelt GUI skulle kunna se ut.

Samtliga delar behöver inte prototypas utan välj en del av ett potentiellt GUI (typ registreringssida eller inmatningssida för en match).

Simulering av match där resultat räknas och en vinnare utses.
