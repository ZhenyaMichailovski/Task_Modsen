
using System.Collections.Generic;
using Task.BusinessLogic.Dtos;

namespace Task.BusinessLogic.Interfaces
{
    public interface IEventService
    {
        public List<FullEventDto> GetAllEvents();
        public FullEventDto GetEventById(int id);
        public void CreateEvent(FullEventDto fullEvent);
        public void UpdateEvent(FullEventDto fullEvent);
        public void DeleteEvent(int id);
    }
}
