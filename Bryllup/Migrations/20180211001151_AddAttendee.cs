using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Bryllup.Migrations
{
    public partial class AddAttendee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Attendee",
                columns: table => new
                {
                    UserName = table.Column<string>(maxLength: 100, nullable: false),
                    Comment = table.Column<string>(maxLength: 4000, nullable: true),
                    Name1 = table.Column<string>(maxLength: 100, nullable: true),
                    Name1Attending = table.Column<bool>(nullable: false),
                    Name2 = table.Column<string>(maxLength: 100, nullable: true),
                    Name2Attending = table.Column<bool>(nullable: false),
                    Phone = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendee", x => x.UserName);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attendee");
        }
    }
}
