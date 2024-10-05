using BloodBankManager.Entities;
using BloodBankManager.Enums;

namespace BloodBankManager.Models
{
    public class AllDonorsViewModel
    {
        public string? NomeCompleto { get; set; }
        public Genero Genero { get; set; }
        public double Peso { get; set; }
        public TipoSanguineo TipoSanguineo { get; set; }
        public FatorRh FatorRh { get; set; }

        public bool Ativo { get; set; }
    }
}