using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AppLoginCoreMs.Data.Migrations
{
    public partial class ModelDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "employee",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    dni = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employee", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "activities",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    dateAct = table.Column<DateTime>(type: "datetime2", nullable: false),
                    employeeid = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_activities", x => x.id);
                    table.ForeignKey(
                        name: "FK_activities_employee_employeeid",
                        column: x => x.employeeid,
                        principalTable: "employee",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "time",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    timeAct = table.Column<double>(type: "float", nullable: false),
                    activitiesid = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_time", x => x.id);
                    table.ForeignKey(
                        name: "FK_time_activities_activitiesid",
                        column: x => x.activitiesid,
                        principalTable: "activities",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_activities_employeeid",
                table: "activities",
                column: "employeeid");

            migrationBuilder.CreateIndex(
                name: "IX_time_activitiesid",
                table: "time",
                column: "activitiesid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "time");

            migrationBuilder.DropTable(
                name: "activities");

            migrationBuilder.DropTable(
                name: "employee");
        }
    }
}
