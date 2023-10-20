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

        public IEnumerable<Input> PopulateInputsWithCoefficients(IEnumerable<Input> inputs)
        {
            foreach (Input input in inputs)
            {
                var inputFromDb = FindByCondition(x => x.Id == input.Id, false).FirstOrDefault<Input>();
                if (inputFromDb != default)
                {
                    input.Co2EqPerKgCoefficient = inputFromDb.Co2EqPerKgCoefficient;
                    input.Co2KgPerHa = inputFromDb.Co2KgPerHa;
                }
            }

            return inputs;
        }
    }
}
