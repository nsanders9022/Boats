using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Boats.Migrations
{
    public partial class ChangePropertiesInControllers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sales_AspNetUsers_AssociateUserId",
                table: "Sales");

            migrationBuilder.DropIndex(
                name: "IX_Sales_AssociateUserId",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "AssociateUserId",
                table: "Sales");

            migrationBuilder.AlterColumn<string>(
                name: "AssociateId",
                table: "Sales",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sales_AssociateId",
                table: "Sales",
                column: "AssociateId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_AspNetUsers_AssociateId",
                table: "Sales",
                column: "AssociateId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sales_AspNetUsers_AssociateId",
                table: "Sales");

            migrationBuilder.DropIndex(
                name: "IX_Sales_AssociateId",
                table: "Sales");

            migrationBuilder.AddColumn<string>(
                name: "AssociateUserId",
                table: "Sales",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AssociateId",
                table: "Sales",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sales_AssociateUserId",
                table: "Sales",
                column: "AssociateUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_AspNetUsers_AssociateUserId",
                table: "Sales",
                column: "AssociateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
