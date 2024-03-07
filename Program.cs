using System;
using System.Collections.Generic;
using Genomg_ng;

class Program
{
    static void Main(string[] args)
    {
        Fordon fordon = new Fordon("Toyota");
        Console.WriteLine(fordon.Märke);
    }
}
