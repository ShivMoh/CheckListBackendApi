using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webapi.Migrations
{
    /// <inheritdoc />
    public partial class new_3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CashierChecklistid",
                table: "fileType",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_fileType_CashierChecklistid",
                table: "fileType",
                column: "CashierChecklistid");

            migrationBuilder.AddForeignKey(
                name: "FK_fileType_cashierChecklist_CashierChecklistid",
                table: "fileType",
                column: "CashierChecklistid",
                principalTable: "cashierChecklist",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_fileType_cashierChecklist_CashierChecklistid",
                table: "fileType");

            migrationBuilder.DropIndex(
                name: "IX_fileType_CashierChecklistid",
                table: "fileType");

            migrationBuilder.DropColumn(
                name: "CashierChecklistid",
                table: "fileType");
        }
    }
}
