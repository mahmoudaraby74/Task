using BLL.Interfaces;
using BLL.internalinterface;
using Task.Interfaces;

namespace BLL.Reposities
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(IClientRepository clientRepository, IOfficeRepository officeRepository)
        {
            ClientRepository = clientRepository;
            OfficeRepository = officeRepository;
        }

        public IClientRepository ClientRepository { get; set; }
        public IOfficeRepository OfficeRepository { get; set; }

    }
}
