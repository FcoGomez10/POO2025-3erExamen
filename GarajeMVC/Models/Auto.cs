namespace GarajeMVC.Models
{
    public class Auto
    {
        public int numeroAuto { get; set; }
        public string Marca { get; set; }
        public string Placa { get; set; }

        // Constructor que inicializa todos los atributos 
        public Auto(int numeroAuto, string marca, string placa)
        {
            this.numeroAuto = numeroAuto;
            this.Marca = marca;
            this.Placa = placa;
        }

    }
}
