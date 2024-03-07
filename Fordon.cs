namespace Genomg_ng
{
    public class Fordon
    {
        protected string märke;

        public Fordon(string märke)
        {
            this.märke = märke; 
        }

        public string Märke
        {
            get{return märke;}
        }
    }
}