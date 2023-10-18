using Contracts;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class InputTypeRepository : RepositoryBase<InputType>, IInputTypeRepository
    {
        public InputTypeRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public IEnumerable<InputType> GetAllInputTypes(bool trackChanges)
        { 
           return FindAll(trackChanges)
           .ToList();
        }
    }
}
