﻿using Task.DataAccess.Interfaces;

namespace Task.DataAccess.Entities
{
    public class EventOrganizer : IId
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public int OrdanizerId { get; set; }
    }
}
