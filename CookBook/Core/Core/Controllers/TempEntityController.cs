using Core.Entities;
using SharedKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Controllers
{
    public class TempEntityController
    {
        private readonly IUnitOfWork _unitOfWork;

        public TempEntityController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
        }

        public async Task<TempEntity> AddNewTempEntity()
        {
            var lastId = (await _unitOfWork.Repository.ListAsync<TempEntity>()).Max(x => x.Id);

            var nextId = lastId + 1;

            return await _unitOfWork.Repository.AddAsync<TempEntity>(new TempEntity
            {
                Id = nextId
            });
        }
    }
}
