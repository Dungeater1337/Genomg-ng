namespace Genomg_ng
{
    public class Cykel : Fordon
    {
        public Cykel(string märke):base(märke)
        {

        }

        public override void Kör()
        {
            Console.WriteLine($"Cyklen {märke} trampar!");
        }
    }
}