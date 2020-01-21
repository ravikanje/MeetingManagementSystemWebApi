using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeetingManagementSystemWebApi.Models;

namespace MeetingManagementSystemWebApi.Models
{
    public class MeetingManagementContext : DbContext
    {

        public MeetingManagementContext(DbContextOptions<MeetingManagementContext> options):base(options)
        {

        }

        public DbSet<MeetingEntity> MeetingDetails { get; set; }

        public DbSet<LoginEntity> LoginEntity { get; set; }
        public DbSet<Attendees> AttendeeList { get; set; }
    }
}
