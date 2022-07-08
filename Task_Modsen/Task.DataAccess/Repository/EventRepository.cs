using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.DataAccess.Entities;

namespace Task.DataAccess.Repository
{
    public class EventRepository : EFRepository<Event>
    {
        public EventRepository(DbContext context) : base(context)
        { }
    }
}
