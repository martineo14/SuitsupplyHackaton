using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Suitsupply.SalesRep.API.Migrations
{
    public partial class AddedAppointment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Review_SalesRepresentatives_SaleRepresentativeId",
                table: "Review");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Review",
                table: "Review");

            migrationBuilder.RenameTable(
                name: "Review",
                newName: "Reviews");

            migrationBuilder.RenameIndex(
                name: "IX_Review_SaleRepresentativeId",
                table: "Reviews",
                newName: "IX_Reviews_SaleRepresentativeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reviews",
                table: "Reviews",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AppointmentDate = table.Column<DateTime>(nullable: false),
                    CustomerEmail = table.Column<string>(nullable: true),
                    CustomerName = table.Column<string>(nullable: true),
                    CustomerPhoneNumber = table.Column<string>(nullable: true),
                    SalesRepEmail = table.Column<string>(nullable: true),
                    SalesRepId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_SalesRepresentatives_SaleRepresentativeId",
                table: "Reviews",
                column: "SaleRepresentativeId",
                principalTable: "SalesRepresentatives",
                principalColumn: "SalesRepId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_SalesRepresentatives_SaleRepresentativeId",
                table: "Reviews");

            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reviews",
                table: "Reviews");

            migrationBuilder.RenameTable(
                name: "Reviews",
                newName: "Review");

            migrationBuilder.RenameIndex(
                name: "IX_Reviews_SaleRepresentativeId",
                table: "Review",
                newName: "IX_Review_SaleRepresentativeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Review",
                table: "Review",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Review_SalesRepresentatives_SaleRepresentativeId",
                table: "Review",
                column: "SaleRepresentativeId",
                principalTable: "SalesRepresentatives",
                principalColumn: "SalesRepId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
