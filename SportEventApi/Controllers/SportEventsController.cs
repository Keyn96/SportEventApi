using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SportEventApi.Models;

namespace SportEventApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SportEventsController : ControllerBase
    {
        private readonly SportEventContext _context;

        public SportEventsController(SportEventContext context)
        {
            _context = context;
        }

        // GET: api/SportEvents
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SportEvent>>> GetSportEventsItems()
        {
            DateTime _dateTime = DateTime.Now;
            return await _context.SportEventsItems.ToListAsync();//Where(x => x.DateEvent.Day == _dateTime.Day).
        }

        // GET: api/SportEvents/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SportEvent>> GetSportEvent(int id)
        {
            var sportEvent = await _context.SportEventsItems.FindAsync(id);

            if (sportEvent == null)
            {
                return NotFound();
            }

            return sportEvent;
        }
    }
}
