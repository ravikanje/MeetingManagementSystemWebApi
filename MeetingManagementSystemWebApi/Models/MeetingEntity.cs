using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingManagementSystemWebApi.Models
{
    public class MeetingEntity
    {
        [Key]
        public int MeetingId { get; set; }
        [Required]
        [Column(TypeName ="varchar(50)")]
        public string MeetingSubject { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(max)")]
        public string MeetingAttendees { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(max)")]
        public string MeetingAgenda { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string MeetingDateTime { get; set; }        
    }
}
