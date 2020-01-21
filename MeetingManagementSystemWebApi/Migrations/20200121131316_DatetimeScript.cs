using Microsoft.EntityFrameworkCore.Migrations;

namespace MeetingManagementSystemWebApi.Migrations
{
    public partial class DatetimeScript : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "MeetingDateTime",
                table: "MeetingDetails",
                type: "nvarchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(10)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "MeetingDateTime",
                table: "MeetingDetails",
                type: "char(10)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)");
        }
    }
}
