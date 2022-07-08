using Microsoft.EntityFrameworkCore;
using Task.DataAccess.Entities;

namespace Task.DataAccess.Repository
{
    class EventOrganizerRepository : EFRepository<EventOrganizer>
    {
        public EventOrganizerRepository(DbContext context) : base(context)
        { }
    }
}
