using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webapi.Migrations
{
    /// <inheritdoc />
    public partial class new_4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_fileType_kitchenCheckList_KitchenCheckListid",
                table: "fileType");

            migrationBuilder.DropIndex(
                name: "IX_fileType_KitchenCheckListid",
                table: "fileType");

            migrationBuilder.DropColumn(
                name: "KitchenCheckListid",
                table: "fileType");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "KitchenCheckListid",
                table: "fileType",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_fileType_KitchenCheckListid",
                table: "fileType",
                column: "KitchenCheckListid");

            migrationBuilder.AddForeignKey(
                name: "FK_fileType_kitchenCheckList_KitchenCheckListid",
                table: "fileType",
                column: "KitchenCheckListid",
                principalTable: "kitchenCheckList",
                principalColumn: "id");
        }
    }
}
