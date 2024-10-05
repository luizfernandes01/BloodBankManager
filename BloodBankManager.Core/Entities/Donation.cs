namespace BloodBankManager.Entities
{
    public class Donation:BaseEntity
    {
        public Donation(int donorId, DateTime donationDate, int quantidadeMl, Donor donor)
            :base()
        {
            DonorId = donorId;
            DonationDate = donationDate;
            QuantidadeMl = quantidadeMl;
            Donor = donor;
        }

        public int DonorId { get;private set; }
        public DateTime DonationDate { get;private set; }
        public int QuantidadeMl { get;private set; }
        public Donor Donor { get; private set; }

        public void Update(int donorId, int quantidadeMl)
        {
            DonorId = donorId;
            QuantidadeMl = quantidadeMl;

        }
    }
}
