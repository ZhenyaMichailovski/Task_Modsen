using Microsoft.EntityFrameworkCore;
using Task.DataAccess.Entities;

namespace Task.DataAccess.Repository
{
    public class PlaceRepository : EFRepository<Place>
    {
        public PlaceRepository(DbContext context) : base(context)
        { }
    }
}
