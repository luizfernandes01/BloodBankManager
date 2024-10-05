using BloodBankManager.Entities;

namespace BloodBankManager.Models
{
    public class CreateDonorInputModel
    {
        public int Id { get; set; }
        public string NomeCompleto { get; set; }
        public String Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Genero { get; set; }
        public double Peso { get; set; }
        public string TipoSanguineo { get; set; }
        public string  FatorRh { get; set; }
        public List<Donation> Donations { get; set; }
        public Endereco Endereco { get; set; }
        public bool Active { get; set; }

    }
}
