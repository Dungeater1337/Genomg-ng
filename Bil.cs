namespace Genomg_ng
{
    public class Bil : Fordon
    {
        private string modell;

        public Bil(string märke, string modell):base(märke)
        {
            this.modell = modell;
            this.märke = märke;
        }

        public string Modell
        {
            get { return modell; }
            set { modell = value; }
        }

        public override void Kör()
        {
            Console.WriteLine($"Bilen {märke} kör som en {modell}!");
        }
    }
}