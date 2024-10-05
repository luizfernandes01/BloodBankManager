using BloodBankManager.Application.Models;
using BloodBankManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankManager.Application.Services
{
    public interface IDonorService
    {
        ResultViewModel<AllDonorsViewModel> GetAll(string search = "");

        ResultViewModel<DonorViewModel>GetById (int id);

        ResultViewModel<int>Inserte(CreateDonorInputModel model);

        ResultViewModel Update(UpdateDonorInputModel model);

        ResultViewModel Delete(int id);
    }
}
