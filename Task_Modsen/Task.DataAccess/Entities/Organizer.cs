using Task.DataAccess.Interfaces;

namespace Task.DataAccess.Entities
{
    public class Organizer : IId
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string TypeOfActivity { get; set; }
    }
}
