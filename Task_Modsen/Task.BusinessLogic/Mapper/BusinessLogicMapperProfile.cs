using AutoMapper;
using Task.BusinessLogic.Dtos;
using Task.DataAccess.Entities;

namespace Task.BusinessLogic.Mapper
{
    public class BusinessLogicMapperProfile : Profile
    {
        public BusinessLogicMapperProfile()
        {

            CreateMap<Event, EventDto>().ReverseMap();

            CreateMap<EventOrganizer, EventOrganizerDto>().ReverseMap();

            CreateMap<Organizer, OrganizerDto>().ReverseMap();

            CreateMap<Place, PlaceDto>().ReverseMap();
        }
    }
}
