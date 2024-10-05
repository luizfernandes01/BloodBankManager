using BloodBankManager.Entities;
using BloodBankManager.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankManager.Core.Repositories
{
    public interface IBloodStorageRepository
    {
        Task<List<BloodStorage>> GetAllStorages();
        Task<BloodStorage> GetStorageById(int id);
        Task<BloodStorage> GetBloodTypeAndFatorRh(TipoSanguineo tipoSanguineo, FatorRh fatorRh);
        void UpdateStorage(BloodStorage bloodStorage);
    }
}
