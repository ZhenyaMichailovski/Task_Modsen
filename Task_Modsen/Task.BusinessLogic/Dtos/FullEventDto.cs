using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.BusinessLogic.Dtos
{
    public class FullEventDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<OrganizerDto> OrganizerDtos { get; set; }
        public DateTimeOffset TimeOfEvent { get; set; }
        public PlaceDto Place { get; set; }
    }
}
