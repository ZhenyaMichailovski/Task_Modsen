using Task.DataAccess.Interfaces;

namespace Task.DataAccess.Entities
{
    public class Place : IId
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
    }
}
