// See https://aka.ms/new-console-template for more information

var myGebaeude = new Gebäude.Gebaeude("HTL", 1200, 5);

var myHaus = new Gebäude.Haus("Herbersstsheusle", 340, 2, 5);

var myStall = new Gebäude.Stall("Gisela", 100, 1, 25);

var mySchule = new Gebäude.Schule("HTL", 2000, 2, 1200);

var mySchule2 = new Gebäude.Schule("HTL", 2000, 4, "ute");


Console.WriteLine("Hello, World!");
Console.WriteLine(myGebaeude.Name);
Console.WriteLine(myGebaeude.Fläche);
Console.WriteLine(myStall.Pferde);

Console.WriteLine(myHaus.Name);

Console.WriteLine(mySchule.Schulkinder + " Schueler an der Schule");

Console.WriteLine(mySchule2.Schueler + " die Schülerin");