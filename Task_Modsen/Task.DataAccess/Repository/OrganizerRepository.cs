using Microsoft.EntityFrameworkCore;
using Task.DataAccess.Entities;

namespace Task.DataAccess.Repository
{
    public class OrganizerRepository : EFRepository<Organizer>
    {
        public OrganizerRepository(DbContext context) : base(context)
        { }
    }
}
