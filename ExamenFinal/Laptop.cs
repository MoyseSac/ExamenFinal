namespace ExamenFinal
{
    public class Laptop : Dispositivos
    {
        public int CantRam {  get; set; }

        public string Almacenamiento { get; set; }


        public Laptop() {
        
            CantRam = 0;
            Almacenamiento = string.Empty;
        
        }

    }
}
