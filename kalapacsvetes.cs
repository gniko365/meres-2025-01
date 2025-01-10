using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

class Sportolo
{
    public int Helyezes { get; set; }
    public double Eredmeny { get; set; }
    public string Nev { get; set; }
    public string Orszagkod { get; set; }
    public string Helyszin { get; set; }
    public string Datum { get; set; }


public Sportolo(string helyezes, string eredmney, sring nev, string orszagkod, string helyszin, string datum)
{
    Helyezes = int.Parse(helyezes);
    Eredmeny = double.Parse (eredmeny, CultureInfo.InvariantCulture);
    Nev = nev;
    Orszagkod = orszagkod;
    Helyszin = helyszin ;
    Datum = datum;
}

}

