using BloodBankManager.Core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankManager.Application.Commands.ActivateDonor
{
    public class ActivateDonorCommandHandler : IRequestHandler<ActivateDonorCommand, Unit>
    {
        public Task<Unit> ActivateDonorCommandHandler(ActivateDonorCommand request, CancellationToken cancellationToken)
        {
             private readonly IDonorRepository _donorRepository;
        public ActivateDonorCommandHandler(IDonorRepository donorRepository)
        {
            _donorRepository = donorRepository;
        }
        public async Task<Unit> Handle(ActivateDonorCommand request, CancellationToken cancellationToken)
        {
            var donor = await _donorRepository.GetDonorByIdAsync(request.Id);

            donor.ActivateDonor();

            await _donorRepository.SaveChangesAsync();

            return Unit.Value;
        }
    }
    }
}
