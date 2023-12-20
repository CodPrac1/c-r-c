using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SampleWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class ThirdMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customerclasses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customerclasses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Inventoryclasses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Make = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerClassId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RegistrationClassId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventoryclasses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Inventoryclasses_Customerclasses_CustomerClassId",
                        column: x => x.CustomerClassId,
                        principalTable: "Customerclasses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Inventoryclasses_Registrationclasses_RegistrationClassId",
                        column: x => x.RegistrationClassId,
                        principalTable: "Registrationclasses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Inventoryclasses_CustomerClassId",
                table: "Inventoryclasses",
                column: "CustomerClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Inventoryclasses_RegistrationClassId",
                table: "Inventoryclasses",
                column: "RegistrationClassId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Inventoryclasses");

            migrationBuilder.DropTable(
                name: "Customerclasses");
        }
    }
}
