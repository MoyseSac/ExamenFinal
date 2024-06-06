namespace ExamenFinal
{
    public class Dispositivos
    {
        public int NoSerie {  get; set; }

        public string Marca {  get; set; }

        public string Modelo { get; set; }

        public Dispositivos() { 
        
            NoSerie = 0;
            Marca=string.Empty;
            Modelo=string.Empty;    
        }   
    }
}
