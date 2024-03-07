using System;
using System.Collections.Generic;
using Genomg_ng;

class Program
{
    static void Main(string[] args)
    {
        List<Fordon> fordonslista = new();

        Bil bil = new Bil("Toyota", "Supra");
        Fordon f2 = new Bil("BMW", "Tursimo");
        fordonslista.Add(bil);
        fordonslista.Add(f2);


        foreach (var fordon in fordonslista)
        {
            fordon.Kör();
        }


    }
}


