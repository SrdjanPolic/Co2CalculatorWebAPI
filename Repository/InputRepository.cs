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
    public class InputRepository : RepositoryBase<Input>, IInputRepository
    {
        public InputRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public IEnumerable<Input> GetAllInputsForInputTypeId(bool trackChanges, Guid inputTypeId)
        {
            return FindAll(trackChanges).Where(x => x.InputTypeId == inputTypeId).ToList();
        }
    }
}
