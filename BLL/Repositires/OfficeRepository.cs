using BLL.Interfaces;
using DAL.Entites;
using Task.Context;

namespace Task.Repositires
{
    public class OfficeRepository : IOfficeRepository
    {
        private readonly AppDbContext _context;

        public OfficeRepository(AppDbContext context) 
        {
            _context = context;
        }


        public int Add(Office office)
        {
            _context.Offices.Add(office);
            return _context.SaveChanges();

        }

        public int Delete(Office office)
        {
            _context.Offices.Remove(office);
            return _context.SaveChanges();
        }


        public Office Get(int? id)
        {
            return _context.Offices.FirstOrDefault(x => x.OfficeId == id);


        }

        public int Update(Office office)
        {
            _context.Offices.Update(office);
            return _context.SaveChanges();
        }

        public IEnumerable<Office> GetAll()
        {
            return _context.Offices.ToList();
        }
    }
}
