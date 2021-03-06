using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using Task.BusinessLogic.Dtos;
using Task.BusinessLogic.Interfaces;
using Task.DataAccess.Entities;
using Task.DataAccess.Interfaces;

namespace Task.BusinessLogic.Services
{
    public class EventService : IEventService
    {
        private readonly IRepository<Event> _eventRepository;
        private readonly IRepository<EventOrganizer> _eventOrganizerRepository;
        private readonly IRepository<Organizer> _organizerRepository;
        private readonly IRepository<Place> _placeRepository;

        private readonly IMapper _mapper;

        public EventService(IRepository<Event> eventRepository, IRepository<EventOrganizer> eventOrganizerRepository,
            IRepository<Organizer> organizerRepository, IRepository<Place> placeRepository, IMapper mapper)
        {
            _eventRepository = eventRepository;
            _eventOrganizerRepository = eventOrganizerRepository;
            _organizerRepository = organizerRepository;
            _placeRepository = placeRepository;
            _mapper = mapper;
        }

        public List<FullEventDto> GetAllEvents()
        {
            var events = _mapper.Map<List<EventDto>>(_eventRepository.GetAll());
            var eventOrganizers = _mapper.Map<List<EventOrganizerDto>>(_eventOrganizerRepository.GetAll());
            var organizers = _mapper.Map<List<OrganizerDto>>(_organizerRepository.GetAll());
            var places = _mapper.Map<List<PlaceDto>>(_placeRepository.GetAll());

            var FullEvents = new List<FullEventDto>();
            foreach(var _event in events)
            {
                var eventOrganizersByEvent = eventOrganizers.FindAll(x => x.EventId == _event.Id);
                var organizersByEvent = organizers.Where(x => eventOrganizersByEvent.Any(y => y.OrdanizerId == x.Id)).ToList();
                FullEvents.Add(new FullEventDto
                {
                    Id = _event.Id,
                    Title = _event.Title,
                    Description = _event.Description,
                    OrganizerDtos = organizersByEvent,
                    Place = places.FirstOrDefault(x => x.Id == _event.PlaceId),
                    TimeOfEvent = _event.TimeOfEvent,
                    
                });
            }

            return FullEvents;
        }

        public FullEventDto GetEventById(int id)
        {
            var _event = _mapper.Map<EventDto>(_eventRepository.GetAll().FirstOrDefault(x => x.Id == id));
            var eventOrganizers = _mapper.Map<List<EventOrganizerDto>>(_eventOrganizerRepository
                .GetAll().Where(x => x.EventId == id));
            var organizers = _mapper.Map<List<OrganizerDto>>(_organizerRepository.GetAll());
            var place = _mapper.Map<PlaceDto>(_placeRepository.GetById(_event.PlaceId));

            var organizersByEvent = organizers.Where(x => eventOrganizers.Any(y => y.OrdanizerId == x.Id)).ToList();

            return new FullEventDto 
            {
                Id = _event.Id,
                Title = _event.Title,
                Description = _event.Description,
                OrganizerDtos = organizersByEvent,
                Place = place,
                TimeOfEvent = _event.TimeOfEvent,
                
            };

        }

        public void CreateEvent(FullEventDto fullEvent)
        {
            var OrganizerDtos = fullEvent.OrganizerDtos;
            List<OrganizerDto> organizers = _mapper.Map<List<OrganizerDto>>(_organizerRepository
                .GetAll().ToList());
            organizers = organizers.Where(x => OrganizerDtos.Any(y => y.Id == x.Id)).ToList();
            var places = _mapper.Map<PlaceDto>(_placeRepository.GetById(fullEvent.Place.Id));

            if (organizers.Count == 0 || places == null)
                throw new System.Exception("");
            var id = _eventRepository.Create(new Event
            {
                Title = fullEvent.Title,
                Description = fullEvent.Description,
                PlaceId = places.Id,
                TimeOfEvent = fullEvent.TimeOfEvent,
            });

            organizers.ForEach(x => _eventOrganizerRepository
            .Create(new EventOrganizer
            {
                EventId = id,
                OrdanizerId = x.Id,
            }));

            
        }

        public void UpdateEvent(FullEventDto fullEvent)
        {
            _eventRepository.Update(new Event
            {
                Id = fullEvent.Id,
                Description = fullEvent.Description,
                PlaceId = _placeRepository.GetById(fullEvent.Place.Id).Id,
                TimeOfEvent = fullEvent.TimeOfEvent,
                Title = fullEvent.Title,
            });
        }

        public void DeleteEvent(int id)
        {
            var eventOrganizers = _eventOrganizerRepository.GetAll().Where(x => x.EventId == id).ToList();
            eventOrganizers.ForEach(x => _eventOrganizerRepository.Delete(x.Id));
            _eventRepository.Delete(id);
        }
    }
}
