# MediaStore

Laborationsuppgift från kurs på Karlstad universitet.

Översikt: Gör ett affärssystem till en fysisk affär som säljer media (böcker, cd/dvd, spel
och liknande). Systemet ska användas av anställda i affären och kunna hantera både
kassahantering och lagerhållning. 

Följande funktionalitet ska finnas i systemet:
A. Lägg till ny produkt (sortimentet utökas)
B. Ta bort produkt (utgår ur sortimentet)
C. Lägg in leverans från grossist (antalet varor av en viss sort ökar)
D. Försäljning av produkt (antalet av sålda varor minskar)
E. Lista alla produkter i sortimentet

Produkter bör ha namn, pris och varunummer (unikt för varje vara).
Systemet ska ha minst två olika vyer (ex. flikar), en för lagerarbete och en för kassabruk
(dock max 1 instans av varje vy). Vyerna ska arbeta mot samma data som ni ska lagra på
fil (ej i databas)*. 

Vid försäljning ska flera varor kunna läggas i en varukorg innan köpet genomförs.
Kontrollfunktion ska finnas så att:
1) Om någon försöker lägga till en ny vara i sortimentet med redan befintligt namn
eller varunummer ska detta ej godkännas och personalen ska få möjlighet att ange
nya uppgifter eller avsluta.
2) Om någon i personalen försöker ta bort en vara ur sortimentet och lagerstatus inte
är noll, så ska en fråga dyka upp om man verkligen vill ta bort varan, då den finns
i lager, varefter valen ”Ja” eller ”Nej” ska finnas i dialogrutan. Om användaren
svarar ”Ja” tas varan bort, annars inte.
3) Om någon försöker öka antalet enheter av en viss vara som ej finns i systemet ska
frågan om man vill lägga till varan dyka upp.
Tänk på att göra systemet så generellt som möjligt. Funktionalitet A, B och C ska endast
kunna utföras från lagerpersonalens vy medan funktionalitet D endast ska kunna utföras
från kassavyn. Funktionalitet E ska kunna utföras från båda vyerna. Systemet ska vara
estetiskt tilltalande och användarvänligt för personalen.

Kodstruktur
Ett krav i denna lab är att konstruktionen bygger på en objektorienterad design med flera
klasser och att varje klass skrivs i en separat fil. Produkterna ska representeras av en
separat klass, som heter ”Produkt”. 
