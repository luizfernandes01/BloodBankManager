using BloodBankManager.Entities;

namespace BloodBankManager.Models
{
    public class UpdateDonorInputModel
    {
        public int Id { get; set; }
        public string NomeCompleto { get; set; }

        public string Genero { get; set; }
        public double Peso { get; set; }
        public Endereco Endereco { get; set; }

    }
}
