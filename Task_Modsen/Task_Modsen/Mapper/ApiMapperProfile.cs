using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task.BusinessLogic.Dtos;
using Task_Modsen.Models;

namespace Task_Modsen.Mapper
{
    public class ApiMapperProfile : Profile
    {
        public ApiMapperProfile()
        {

            CreateMap<FullEventDto, EventModel>().ReverseMap();

            CreateMap<PlaceDto, PlaceModel>().ReverseMap();

            CreateMap<OrganizerDto, OrganizerModel>().ReverseMap();
        }
    }
}
