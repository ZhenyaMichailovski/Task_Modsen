using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.DataAccess.Entities;

namespace Task.DataAccess.Repository
{
    public class PlaceRepository : EFRepository<Place>
    {
        public PlaceRepository(DbContext context) : base(context)
        { }
    }
}
