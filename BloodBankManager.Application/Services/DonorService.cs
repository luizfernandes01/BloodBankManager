using BloodBankManager.Application.Models;
using BloodBankManager.Models;
using BloodBankManager.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankManager.Application.Services
{
    public class DonorService : IDonorService
    {
        private readonly BloodBankManagerDbContext _context;
        public DonorService(BloodBankManagerDbContext context)
        {
            _context = context;
        }
        public ResultViewModel Delete(int id)
        {

            var donor = _context.Donors.SingleOrDefault(d => d.Id == id);

            _context.Donors.Update(donor);
            _context.SaveChanges();

            return ResultViewModel.Success();
        }

        public ResultViewModel<AllDonorsViewModel> GetAll(string search = "")
        {
            var donors = _context.Donors.ToList();

            var model = donors.Select(AllDonorsViewModel.FromEntity).Tolist();

            return ResultViewModel<AllDonorsViewModel>.Success(model);
        }

        public ResultViewModel<DonorViewModel> GetById(int id)
        {
            var donor = _context.Donors.SingleOrDefault(d => d.Id == id);

            return ResultViewModel<DonorViewModel>.Success(model);
        }

        public ResultViewModel<int> Inserte(CreateDonorInputModel model)
        {

            var donor = _context.Donors.ToList().First();

            _context.Donors.Add(donor);
            _context.SaveChanges();

            return ResultViewModel<int>.Success(donor.Id);
        }

        public ResultViewModel Update(UpdateDonorInputModel model)
        {
            var donor = _context.Donors.SingleOrDefault(d => d.Id == model.IdDonor);

            _context.Donors.Update(donor);
            _context.SaveChanges();

            return ResultViewModel.Success();
        }
    }
}
