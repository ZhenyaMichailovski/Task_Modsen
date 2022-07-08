using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.DataAccess.Interfaces;

namespace Task.DataAccess.Entities
{
    public class Event : IId
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int EventOrganizerId { get; set; }
        public DateTimeOffset TimeOfEvent { get; set; }
        public int PlaceId { get; set; }
    }
}
