using Task.Entites;

namespace Task.Interfaces
{
    public interface IClientRepository
    {
        Client Get(int? clientid);
        IEnumerable<Client> GetALL();

        int Add(Client client);
        int Update(Client client);
        int Delete(Client client);

    }
}
