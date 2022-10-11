using Microsoft.EntityFrameworkCore.Migrations;

namespace In.ProjectEKA.HipService.Migrations
{
    public partial class PatientQueue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PatientQueue",
                columns: table => new
                {
                    RequestId = table.Column<string>(nullable: false),
                    DateTimeStamp = table.Column<string>(nullable: true),
                    HipCode = table.Column<string>(nullable: true),
                    Profile = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientQueue", x => x.RequestId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PatientQueue");
        }
    }
}