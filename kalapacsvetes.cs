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

class program {

    static List<Sportolo> SportolokBeolvasása(string kalapacsvetes.txt)
    {

        var sportolok = new List<Sportolo>();
        var lines = File.ReadAllLines(kalapacsvetes.txt);

        foreach (var line in lines.Skip(1))
        {

            var splitLine = line.Split(';');
            var sportolo = new Sportolo(splitLine[0], splitLine[1], splitLine[2], splitLine[3], splitLine[4], splitLine[5]);
            sportolok.Add(sportolo);
        }
        return sportolok;
    }

    static int HanyDobas(List<Sportolo> sportolok)
    {
        return sportolok.Count;
    }

     static double? MagyarAtlag(List<Sportolo> sportolok)
    {
        var magyarok = sportolok.Where(s => s.Orszagkod == "HUN").ToList();
        if (magyarok.Any())
        {
            return Math.Round(magyarok.Average(s => s.Eredmeny), 2);
        }
        return null;
    }

    static List<Sportolo> DobasEvben(List<Sportolo> sportolok, int ev)
    {
        return sportolok.Where(s => s.Datum.StartsWith(ev.ToString())).ToList();
    }

    static void OrszagStatisztika(List<Sportolo> sportolok)
    {
        var statisztika = sportolok
            .GroupBy(s => s.Orszagkod)
            .Select(g => new { Orszag = g.Key, Db = g.Count() })
            .OrderByDescending(s => s.Db);

        foreach (var item in statisztika)
        {
            Console.WriteLine($"{item.Orszag}: {item.Db} dobás");
        }
    }

static void MagyarokFajlba(List<Sportolo> sportolok, string fajlnev)
    {
        var magyarok = sportolok.Where(s => s.Orszagkod == "HUN").ToList();
        using (StreamWriter writer = new StreamWriter(fajlnev))
        {
            writer.WriteLine("Helyezés;Eredmény;Név;Országkód;Helyszín;Dátum");
            foreach (var sportolo in magyarok)
            {
                writer.WriteLine($"{sportolo.Helyezes};{sportolo.Eredmeny:F2};{sportolo.Nev};{sportolo.Orszagkod};{sportolo.Helyszin};{sportolo.Datum}");
            }
        }
    }

    static void Main(string[] args)
    {
        string fajlnev = "kalapacsvetes.txt";
        var sportolok = SportolokBeolvasasa(fajlnev);

}

