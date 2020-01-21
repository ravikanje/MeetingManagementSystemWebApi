using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingManagementSystemWebApi.Models
{
    public class Attendees
    {
        [Key]
        public int AttendeeId { get; set; }
        public string AttendeeDisplayName { get; set; }
    }
}
