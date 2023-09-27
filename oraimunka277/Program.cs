using System;
using System.Collections.Generic;
using System.IO;

public class Varos
{
    public string Megnevezes;
    public string OrszagKod;
    public string SzelessegKoord;
    public string HosszusagKoord;

    public Varos(string megnevezes, string orszagKod, string szelessegKoord, string hosszusagKoord)
    {
        Megnevezes = megnevezes;
        OrszagKod = orszagKod;
        SzelessegKoord = szelessegKoord;
        HosszusagKoord = hosszusagKoord;
    }

    public override string ToString()
    {
        return $"Város: {Megnevezes}, Ország kódja: {OrszagKod}, Szélességi koordináta: {SzelessegKoord}, Hosszúsági koordináta: {HosszusagKoord}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Varos> varosok = new List<Varos>();
            using (StreamReader sr = new StreamReader("varosok.txt"))
            {
                string sor;
                while ((sor = sr.ReadLine()) != null)
                {
                    string[] adatok = sor.Split(';');
                    if (adatok.Length == 4)
                    {
                        string megnevezes = adatok[0];
                        string orszagKod = adatok[1];
                        string szelessegKoord = adatok[2];
                        string hosszusagKoord = adatok[3];

                        Varos varos = new Varos(megnevezes, orszagKod, szelessegKoord, hosszusagKoord);
                        varosok.Add(varos);
                    }
                }
            }

            Console.WriteLine("Az összes város adatai:");
            foreach (var varos in varosok)
            {
                Console.WriteLine(varos.ToString());
            }
    }
}
