using BloodBankManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankManager.Core.Repositories
{
    public interface IDonorRepository
    {
        Task<List<Donor>> GetAllDonorsAsync();
        Task<Donor> GetDonorByIdAsync(int id);
        Task<Donor> GetDonorWithDonationsById(int id);
        Task<List<Donor>> GetDonorsActivo();
        Task<List<Donor>> GetDonorsInativo();
        Task AddDonorAsync(Donor donor);
        Task SaveChangesAsync();
        Task DeleteDonorAsync(int id);
        Task ActivateDonor(int id);
        Task<bool> CheckEmailNoExists(string email);
    }
}
