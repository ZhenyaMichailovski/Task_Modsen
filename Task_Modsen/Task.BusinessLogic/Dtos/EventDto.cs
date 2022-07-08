using System;

namespace Task.BusinessLogic.Dtos
{
    public class EventDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTimeOffset TimeOfEvent { get; set; }
        public int PlaceId { get; set; }
    }
}
