namespace GarajeMVC.Models
{

    public class Garaje
    {
        public int noGaraje { get; set; }
        public string Descripcion { get; set; }
        public int capEspacios { get; set; }
        public int espOcupados { get; set; }

        public List<Auto> autos = new List<Auto>();
        public void ingresarAuto(Auto auto)
        {
            this.autos.Add(auto);
            this.espOcupados++;
        }

        public List<Auto> getAutos()  
        {
            return this.autos;
        }

        // Constructor que inicializa todos los atributos 
        public Garaje(int numeroGaraje, string descripcion, int capacidadEspacios, int espaciosOcupados)
        {
            this.noGaraje = numeroGaraje;
            this.Descripcion = descripcion;
            this.capEspacios = capacidadEspacios;
            this.espOcupados = espaciosOcupados;

        }

        public Garaje()
        {
        }
    }
}
