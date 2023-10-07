using Contracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private RepositoryContext _repositoryContext;
        private IInputRepository _inputRepository;
        private IInputTypeRepository _inputTypeRepository;
        private ICultureRepository _cultureRepository;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }

        public ICultureRepository Culture
        {
            get
            {
                if (_cultureRepository == null)
                    _cultureRepository = new CultureRepository(_repositoryContext);

                return _cultureRepository;
            }
        }

        public IInputTypeRepository InputType
        {
            get
            {
                if (_inputTypeRepository == null)
                    _inputTypeRepository = new InputTypeRepository(_repositoryContext);

                return _inputTypeRepository;
            }
        }

        public IInputRepository Input
        {
            get
            {
                if (_inputRepository == null)
                    _inputRepository = new InputRepository(_repositoryContext);

                return _inputRepository;
            }
        }

    
        public void Save() => _repositoryContext.SaveChanges();
    }
}
