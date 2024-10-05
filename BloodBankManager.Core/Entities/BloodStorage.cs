using BloodBankManager.Enums;

namespace BloodBankManager.Entities
{
    public class BloodStorage:BaseEntity
    {
        public BloodStorage(TipoSanguineo tipoSanguineo, FatorRh fatorRh, int quantidadeMl)
            :base()
        {
            
            
            TipoSanguineo = tipoSanguineo;
            FatorRh = fatorRh;
            QuantidadeMl = quantidadeMl;
        }

        public TipoSanguineo TipoSanguineo { get; private set; }
        public FatorRh FatorRh { get; private set; }
        public int QuantidadeMl { get; private set; }

        public void UpdateQuantidade(int quantidadeMl)
        {
            QuantidadeMl += quantidadeMl;
        }
    }
}
