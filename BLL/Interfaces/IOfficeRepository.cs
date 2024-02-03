
using DAL.Entites;
using Task.Entites;

namespace BLL.Interfaces
{
    public interface IOfficeRepository
    {
        Office Get(int? officeid);
        IEnumerable<Office> GetAll();
        int Add(Office office);
        int Update(Office office);
        int Delete(Office office);
        object Delete(Client client);
        object Update(Client client);
    }
}
