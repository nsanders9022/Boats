using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Boats.Migrations
{
    public partial class ChangeJoinTableName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssociatesBoats");

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    AssociateBoatId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AssociateId = table.Column<int>(nullable: false),
                    AssociateUserId = table.Column<string>(nullable: true),
                    BoatId = table.Column<int>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    Commission = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.AssociateBoatId);
                    table.ForeignKey(
                        name: "FK_Sales_AspNetUsers_AssociateUserId",
                        column: x => x.AssociateUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sales_Boats_BoatId",
                        column: x => x.BoatId,
                        principalTable: "Boats",
                        principalColumn: "BoatId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sales_AssociateUserId",
                table: "Sales",
                column: "AssociateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_BoatId",
                table: "Sales",
                column: "BoatId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.CreateTable(
                name: "AssociatesBoats",
                columns: table => new
                {
                    AssociateBoatId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AssociateId = table.Column<int>(nullable: false),
                    AssociateUserId = table.Column<string>(nullable: true),
                    BoatId = table.Column<int>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    Commission = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssociatesBoats", x => x.AssociateBoatId);
                    table.ForeignKey(
                        name: "FK_AssociatesBoats_AspNetUsers_AssociateUserId",
                        column: x => x.AssociateUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AssociatesBoats_Boats_BoatId",
                        column: x => x.BoatId,
                        principalTable: "Boats",
                        principalColumn: "BoatId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AssociatesBoats_AssociateUserId",
                table: "AssociatesBoats",
                column: "AssociateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AssociatesBoats_BoatId",
                table: "AssociatesBoats",
                column: "BoatId");
        }
    }
}
