namespace Genomg_ng
{
    public abstract class Fordon
    {
        protected string märke;

        public Fordon(string märke)
        {
            this.märke = märke; 
        }

        
        public string Märke
        {
            set{märke = value;}
            get{return märke;}
        }

        public abstract void Kör();
    }
}