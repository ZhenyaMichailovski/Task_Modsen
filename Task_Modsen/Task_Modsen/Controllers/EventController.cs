using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task.BusinessLogic.Dtos;
using Task.BusinessLogic.Interfaces;
using Task_Modsen.Models;

namespace Task_Modsen.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private IEventService _eventService;

        private IMapper _mapper;

        public EventController(IEventService eventService, IMapper mapper)
        {
            _eventService = eventService;
            _mapper = mapper;
        }

        [HttpPost]
        [ActionName("CreateEvent")]
        public async Task<ActionResult<EventModel>> CreateEvent(EventModel item)
        {
            _eventService.CreateEvent(_mapper.Map<FullEventDto>(item));

            return Ok(item);
        }

        [HttpDelete("{id}")]
        [ActionName("DeleteEvent")]
        public async Task<ActionResult<EventModel>> DeleteEvent(int id)
        {
            _eventService.DeleteEvent(id);
            return Ok(id);
        }

        [HttpGet]
        [ActionName("GetAllEvents")]
        public async Task<ActionResult<IEnumerable<EventModel>>> GetAllEvents()
        {
            var items = _mapper.Map<List<EventModel>>(_eventService.GetAllEvents());
            
            return await System.Threading.Tasks.Task.FromResult(items);
        }

        [HttpGet("{id}")]
        [ActionName("GetEventById")]
        public async Task<ActionResult<EventModel>> GetEventById(int id)
        {
            var response = _eventService.GetEventById(id);

            return new ObjectResult(_mapper.Map<EventModel>(response));
        }

        [HttpPut]
        [ActionName("UpdateEvent")]
        public async Task<ActionResult<EventModel>> UpdateEvents(EventModel item)
        {
            _eventService.UpdateEvent(_mapper.Map<FullEventDto>(item));
            return Ok(item);
        }
    }
}
