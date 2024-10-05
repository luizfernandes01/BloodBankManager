namespace BloodBankManager.Models
{
    public class DonorAndDonationsViewModel
    {
        public string NomeCompleto { get; set; }
        public string TipoSanguineo { get; set; }
        public string FatorRh { get; set; }
        public bool Ativo { get; set; }
        public List<DonationViewModelRelatory> Donations { get; set; }

    }
}
