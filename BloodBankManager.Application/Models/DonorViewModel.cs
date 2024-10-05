using BloodBankManager.Entities;
using BloodBankManager.Enums;

namespace BloodBankManager.Models
{
    public class DonorViewModel
    {
        public DonorViewModel(string? nomeCompleto, string genero, double peso, TipoSanguineo tipoSanguineo, FatorRh fatorRh, Endereco endereco)
        {
            NomeCompleto = nomeCompleto;
            Genero = genero;
            Peso = peso;
            TipoSanguineo = tipoSanguineo;
            FatorRh = fatorRh;
            Endereco = endereco;
            Ativo = Ativo;
        }

        public string? NomeCompleto { get; set; }
        public string Genero { get; set; }
        public double Peso { get; set; }
        public TipoSanguineo TipoSanguineo { get; set; }
        public FatorRh FatorRh { get; set; }
        public Endereco Endereco { get; set; }
        public bool Ativo { get; set; }

        public static DonorViewModel FromEntity(Donor entity)
            =>new(entity.NomeCompleto,entity.Genero,entity.Peso,entity.TipoSanguineo,entity.FatorRh,entity.Endereco);
    }
}
