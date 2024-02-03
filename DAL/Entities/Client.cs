using DAL.Entites;

namespace Task.Entites
{
    public class Client
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public int OfficeId { get; set; }
        public Office Office { get; set; }
    }
}
