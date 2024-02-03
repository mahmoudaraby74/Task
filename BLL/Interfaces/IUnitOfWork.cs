using BLL.Interfaces;
using Task.Interfaces;

namespace BLL.internalinterface
{
    public interface IUnitOfWork
{
        public IClientRepository ClientRepository { get; set; }
        public IOfficeRepository OfficeRepository { get; set; }


    }
}
