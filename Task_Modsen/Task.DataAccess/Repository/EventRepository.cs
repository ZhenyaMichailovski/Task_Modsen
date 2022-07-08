using Microsoft.EntityFrameworkCore;
using Task.DataAccess.Entities;

namespace Task.DataAccess.Repository
{
    public class EventRepository : EFRepository<Event>
    {
        public EventRepository(DbContext context) : base(context)
        { }
    }
}
