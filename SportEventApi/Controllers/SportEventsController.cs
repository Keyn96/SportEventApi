using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SportEventApi.DBModels;

namespace SportEventApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SportEventsController : ControllerBase
    {
        private readonly SportEventsContext _context;

        public SportEventsController(SportEventsContext context)
        {
            _context = context;
        }

        // GET: api/SportEvents
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SportEvent>>> GetSportEvents()
        {
            DateTime _dateTime = DateTime.Now;
            return  await _context.SportEvent.Where(x => x.Date.Day == _dateTime.Day).ToListAsync();
        }

        // GET: api/SportEvents/GetSportEventsInDatePeriod?date1&date2
        [HttpGet("{dateStart, dateEnd}")]
        public async Task<ActionResult<IEnumerable<SportEvent>>> GetSportEventsInDatePeriod(DateTime dateStart, DateTime dateEnd)
        {
            return await _context.SportEvent.Where(x => x.Date.Date >= dateStart.Date && x.Date.Date <= dateEnd.Date).ToListAsync();
        }
    }
}
