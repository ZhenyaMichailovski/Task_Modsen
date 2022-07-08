using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.DataAccess.Interfaces;

namespace Task.DataAccess.Entities
{
    public class EventOrganizer : IId
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public int OrdanizerId { get; set; }
    }
}
