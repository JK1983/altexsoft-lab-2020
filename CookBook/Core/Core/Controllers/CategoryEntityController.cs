using Core.Entities;
using SharedKernel;
using SharedKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Controllers
{
    public class CategoryController
    {
        private readonly IUnitOfWork _unitOfWork;
        private CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
        }
        public async Task<Category> AddNewCategory()
        {
            var lastId = (await _unitOfWork.Repository.ListAsync<Category>()).Max(x => x.Id);
            var nextId = lastId + 1;
            return await _unitOfWork.Repository.AddAsync<Category>(new Category { Id = nextId });
        }
    }
}
