using BloodBankManager.Enums;
using System.Collections.Specialized;

namespace BloodBankManager.Entities
{
    public  class Donor:BaseEntity
    {
        public Donor() { }

        public Donor(string nomeCompleto, string email, DateTime dataNascimento, string genero, double peso, TipoSanguineo tipoSanguineo, FatorRh fatorRh, Endereco endereco)
        {
            NomeCompleto = nomeCompleto;
            Email = email;
            DataNascimento = dataNascimento;
            Genero = genero;
            Peso = peso;
            TipoSanguineo = tipoSanguineo;
            FatorRh = fatorRh;
            Endereco = endereco;
            Ativo = true;
            Donations = new List<Donation>();

        }

        public string NomeCompleto { get;private set; }
        public String Email { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public string Genero { get; private set; }
        public double Peso { get; private set; }
        public TipoSanguineo TipoSanguineo { get; private set; }
        public FatorRh FatorRh { get; private set; }

        public Endereco Endereco { get; private set; }
        public List<Donation> Donations { get ; private set; }
       
        public bool Ativo { get; private set; }

        public void Update(string nomeCompleto,string genero,double peso,Endereco endereco)
        {
            NomeCompleto = nomeCompleto;
            Genero = genero;
            Peso = peso;
            Endereco = endereco;
        }
        public void InativoDonor()
        {
            Ativo = false;
        }
        public void AtivadoDonor()
        {
            Ativo = true;
        }
    }
}
