using System;
using Task.DataAccess.Interfaces;

namespace Task.DataAccess.Entities
{
    public class Event : IId
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTimeOffset TimeOfEvent { get; set; }
        public int PlaceId { get; set; }
    }
}
