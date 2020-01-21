using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MeetingManagementSystemWebApi.Models;
using Microsoft.AspNetCore.Cors;

namespace MeetingManagementSystemWebApi.Controllers
{
    [EnableCors("AllowFromAll")]
    [Route("api/[controller]")]
    [ApiController]
    public class MeetingManagementController : ControllerBase
    {
        private readonly MeetingManagementContext _context;

        public MeetingManagementController(MeetingManagementContext context)
        {
            _context = context;
        }

        // GET: api/MeetingManagement
        [HttpGet]
        public IActionResult GetMeetingDetails()
        {
            var list= _context.MeetingDetails;
            return Ok(new { status = 200, result = list });
        }

        [HttpGet("GetAttendees")]
        public IActionResult GetAttendees()
        {
            var list= _context.AttendeeList;
            return Ok(new { status = 200, result = list });
        }

       
        [HttpPut]
        public IActionResult PutMeetingEntity([FromBody] MeetingEntity meetingEntity)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }           
            _context.Entry(meetingEntity).State = EntityState.Modified;

            try
            {
                _context.SaveChanges();
                return Ok(new { status = 200, message = "", result = meetingEntity });
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MeetingEntityExists(meetingEntity.MeetingId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/MeetingManagement
        [HttpPost]
        public IActionResult PostMeetingEntity([FromBody] MeetingEntity meetingEntity)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MeetingDetails.Add(meetingEntity);
            _context.SaveChanges();

            return Ok(new { status = 200, message = "", result = meetingEntity });
        }

        private bool MeetingEntityExists(int id)
        {
            return _context.MeetingDetails.Any(e => e.MeetingId == id);
        }
    }
}