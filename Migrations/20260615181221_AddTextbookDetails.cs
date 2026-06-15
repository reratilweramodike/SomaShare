using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SomaShareApp.Migrations
{
    /// <inheritdoc />
    public partial class AddTextbookDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Condition",
                table: "Textbooks",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Campus",
                table: "Textbooks",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CourseCode",
                table: "Textbooks",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Textbooks",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Isbn",
                table: "Textbooks",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SellerId",
                table: "Textbooks",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Textbooks",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Textbooks_SellerId",
                table: "Textbooks",
                column: "SellerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Textbooks_AspNetUsers_SellerId",
                table: "Textbooks",
                column: "SellerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Textbooks_AspNetUsers_SellerId",
                table: "Textbooks");

            migrationBuilder.DropIndex(
                name: "IX_Textbooks_SellerId",
                table: "Textbooks");

            migrationBuilder.DropColumn(
                name: "CourseCode",
                table: "Textbooks");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Textbooks");

            migrationBuilder.DropColumn(
                name: "Isbn",
                table: "Textbooks");

            migrationBuilder.DropColumn(
                name: "SellerId",
                table: "Textbooks");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Textbooks");

            migrationBuilder.AlterColumn<string>(
                name: "Condition",
                table: "Textbooks",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "Campus",
                table: "Textbooks",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");
        }
    }
}
