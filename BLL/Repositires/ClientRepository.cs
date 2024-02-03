using DAL.Entites;
using Microsoft.EntityFrameworkCore;
using Task.Context;
using Task.Entites;
using Task.Interfaces;

namespace BLL.Repositires
{
    public class ClientRepository : IClientRepository
    {
        private readonly AppDbContext _context;

        public ClientRepository(AppDbContext context)
        {
            _context = context;
        }
        public int Add(Client client)
        {
            _context.Clients.Add(client);
            return _context.SaveChanges();
        }

        public int Delete(Client client)
        {
            _context.Clients.Remove(client);
             return _context.SaveChanges();        }

        public Client Get(int? clientid)
        {
            return _context.Clients.FirstOrDefault(x => x.ClientId == clientid);
        }

        public IEnumerable<Client> GetALL()
        {
            return _context.Clients.ToList();
        }

        public int Update(Client client)
        {
            _context.Clients.Update(client);
            return _context.SaveChanges();
        }
    }
}
