using Task.Entites;

namespace DAL.Entites
{
    public class Office
    {
        public int OfficeId { get; set; }
        public string Name { get; set; }
        public ICollection<Client> Clients { get; set; }
    }
}
