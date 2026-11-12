using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Encodings.Web;

namespace TeniszpalyaFoglalas
{
    public class Foglalas
    {
        public string JatekosNev { get; set; }
        public int FoglaltOrak { get; set; }
        public int BereltUtoDb { get; set; }

        public Foglalas(string sor)
        {
            string[] darabolt = sor.Split(';');
            JatekosNev = darabolt[0];
            FoglaltOrak = int.Parse(darabolt[1]);
            BereltUtoDb = int.Parse(darabolt[2]);
        }

        public int FizetendoDij()
        {
            return FoglaltOrak * 3500 + BereltUtoDb * 800;
        }

        public override string ToString()
        {
            return $"{JatekosNev}: {FoglaltOrak} óra, {BereltUtoDb} db bérelt ütő - Fizetendő: {FizetendoDij()} Ft";
        }
    }
}
