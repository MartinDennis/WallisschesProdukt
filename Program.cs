//*Programmieren Sie eine C#-Klasse WallisschesProdukt,
//welche eine Methode enthält, die das wallissche Produkt bis zum n-ten Faktor
//berechnet und zurückgibt. Diese Klasse darf keine Ein-/Ausgabefunktionen
//wie bspw. Console.WriteLine() enthalten. Schreiben Sie ein Hauptprogramm,
//in dem Sie in einer forSchleife für alle n von 1 bis 1000 das Produkt ausgeben.
//Vergleichen Sie die berechneten Ergebnisse mit dem konstanten Wert Math.PI 
//(etwa indem Sie zusätzlich die Differenz Ihres berechneten Wertes zu Math.PI ausgeben).
//Die Produktformel zur Berechnung des wallisschen Produkts ist nicht zu verwenden.

using System;

class wallissches_Produkt
{

     static double Berechnug(int n)
    {
        double Ergebnis = 1;
        

        for (double i = 2; i <= (2 * n); i += 2)
        {
            Ergebnis *= (i / (i - 1)) * (i / (i + 1));
        }
        return Ergebnis * 2;
       
    }

     static double Differenz(int n)
    {
        double Ergebnis = 1;


        for (double i = 2; i <= (2 * n); i += 2)
        {
            Ergebnis *= (i / (i - 1)) * (i / (i + 1));
        }
        return Math.PI - Ergebnis * 2;

    }

    public static void Main()
    {
         int counter = 1;
        //Console.WriteLine("Geben Sie den Faktor n ein: 
        for (counter = 1; counter < 101; counter++)
        {
            Console.WriteLine("   Das Wallissche Produkt für n = "+counter+" ist:" + wallissches_Produkt.Berechnug(counter));
            Console.WriteLine("   Die Differenz zwichen dem Wallisschen Produkt und Math.Pi ist:" + wallissches_Produkt.Differenz(counter));
            Console.WriteLine("|-----------------------------------------------------------------------------------|");
        }
            Console.ReadLine();     
    }
}
