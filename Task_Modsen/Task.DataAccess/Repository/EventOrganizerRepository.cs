using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.DataAccess.Entities;

namespace Task.DataAccess.Repository
{
    class EventOrganizerRepository : EFRepository<EventOrganizer>
    {
        public EventOrganizerRepository(DbContext context) : base(context)
        { }
    }
}
