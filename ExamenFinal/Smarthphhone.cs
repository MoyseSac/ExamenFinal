namespace ExamenFinal
{
    public class Smarthphhone : Dispositivos
    {
        public string Sistema {  get; set; }

        public int NoCamaras { get; set; }

        public Smarthphhone() { 
        
            Sistema = string.Empty;
            NoCamaras = 0;
        }
    }
}
