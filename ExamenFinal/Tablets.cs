namespace ExamenFinal
{
    public class Tablets : Dispositivos
    {
        public string TamanoPantalla { get; set; }

        public string Soporte { get; set; }
        public Tablets()
        {
            TamanoPantalla = string.Empty;
            Soporte = string.Empty;
        }
    }
}
