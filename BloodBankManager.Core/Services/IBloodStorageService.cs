using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankManager.Core.Services
{
    public interface IBloodStorageService
    {
        Task AddBloodStorage(int donorId, int quantityMl);
    }
}
