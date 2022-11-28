using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NordicDoorWeb.Migrations
{
    /// <inheritdoc />
    public partial class AddForslagToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Forslags",
                columns: table => new
                {
                    ForslagId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnsattId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tittel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Årsak = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mål = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Løsning = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatoRegistrert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Frist = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Team = table.Column<int>(type: "int", nullable: false),
                    Ansvarlig = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Forslags", x => x.ForslagId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Forslags");
        }
    }
}
