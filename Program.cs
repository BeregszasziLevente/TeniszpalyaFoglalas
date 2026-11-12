using TeniszpalyaFoglalas;
using System.IO;

List<Foglalas> foglalasok = new List<Foglalas>();

foreach (var sor in File.ReadAllLines("foglalasok.txt"))
{
    Foglalas peldany = new Foglalas(sor);
    foglalasok.Add(peldany);
}