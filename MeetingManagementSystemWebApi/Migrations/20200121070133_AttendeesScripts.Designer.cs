﻿// <auto-generated />
using MeetingManagementSystemWebApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MeetingManagementSystemWebApi.Migrations
{
    [DbContext(typeof(MeetingManagementContext))]
    [Migration("20200121070133_AttendeesScripts")]
    partial class AttendeesScripts
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MeetingManagementSystemWebApi.Models.Attendees", b =>
                {
                    b.Property<int>("AttendeeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AttendeeDisplayName");

                    b.HasKey("AttendeeId");

                    b.ToTable("AttendeeList");
                });

            modelBuilder.Entity("MeetingManagementSystemWebApi.Models.LoginEntity", b =>
                {
                    b.Property<int>("LoginId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<string>("UserName")
                        .IsRequired();

                    b.HasKey("LoginId");

                    b.ToTable("LoginEntity");
                });

            modelBuilder.Entity("MeetingManagementSystemWebApi.Models.MeetingEntity", b =>
                {
                    b.Property<int>("MeetingId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MeetingAgenda")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MeetingAttendees")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MeetingDateTime")
                        .IsRequired()
                        .HasColumnType("char(10)");

                    b.Property<string>("MeetingSubject")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("MeetingId");

                    b.ToTable("MeetingDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
