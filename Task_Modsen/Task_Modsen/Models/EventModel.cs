using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task_Modsen.Models
{
    public class EventModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<OrganizerModel> OrganizerDtos { get; set; }
        public DateTimeOffset TimeOfEvent { get; set; }
        public PlaceModel Place { get; set; }
    }
}
