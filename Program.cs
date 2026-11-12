using TeniszpalyaFoglalas;
using System.IO;

List<Foglalas> foglalasok = new List<Foglalas>();

Console.WriteLine("Adatok beolvasása a foglalasok.txt fájlból...");
Console.WriteLine("\nNapi pályafoglalások:");

foreach (var sor in File.ReadAllLines("foglalasok.txt"))
{
    Foglalas peldany = new Foglalas(sor);
    foglalasok.Add(peldany);
    Console.WriteLine(peldany);
}

Console.WriteLine("\nStatisztika:");
Console.WriteLine($"Teniszcentrum teljes napi bevétele: {foglalasok.Sum(x=>x.FizetendoDij())} Ft");
Console.WriteLine($"Legtöbb órát foglaló játékos: {foglalasok.MaxBy(x=>x.FoglaltOrak).JatekosNev} ({foglalasok.Max(x => x.FoglaltOrak)} óra)");