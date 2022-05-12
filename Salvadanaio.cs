namespace csharp_es03_mattina
{
    internal class Salvadanaio
    {
        private int iTotale;
        public int Add(int iValore)
        {
            iTotale += iValore;
            return iTotale;
        }
        public Salvadanaio()
        {
            iTotale = 0;    
        }
    }
}