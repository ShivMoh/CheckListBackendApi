using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webapi.Migrations
{
    /// <inheritdoc />
    public partial class @new : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_kitchenCheckList_aromaticsServer_aromaticsServerid",
                table: "kitchenCheckList");

            migrationBuilder.DropIndex(
                name: "IX_kitchenCheckList_aromaticsServerid",
                table: "kitchenCheckList");

            migrationBuilder.DropIndex(
                name: "IX_cashierChecklist_commentId",
                table: "cashierChecklist");

            migrationBuilder.DropIndex(
                name: "IX_cashierChecklist_signatureId",
                table: "cashierChecklist");

            migrationBuilder.DropColumn(
                name: "aromaticsServerid",
                table: "kitchenCheckList");

            migrationBuilder.AlterColumn<Guid>(
                name: "signatureId",
                table: "cashierChecklist",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "commentId",
                table: "cashierChecklist",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.CreateIndex(
                name: "IX_cashierChecklist_commentId",
                table: "cashierChecklist",
                column: "commentId",
                unique: true,
                filter: "[commentId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_cashierChecklist_signatureId",
                table: "cashierChecklist",
                column: "signatureId",
                unique: true,
                filter: "[signatureId] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_cashierChecklist_commentId",
                table: "cashierChecklist");

            migrationBuilder.DropIndex(
                name: "IX_cashierChecklist_signatureId",
                table: "cashierChecklist");

            migrationBuilder.AddColumn<Guid>(
                name: "aromaticsServerid",
                table: "kitchenCheckList",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<Guid>(
                name: "signatureId",
                table: "cashierChecklist",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "commentId",
                table: "cashierChecklist",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_kitchenCheckList_aromaticsServerid",
                table: "kitchenCheckList",
                column: "aromaticsServerid");

            migrationBuilder.CreateIndex(
                name: "IX_cashierChecklist_commentId",
                table: "cashierChecklist",
                column: "commentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_cashierChecklist_signatureId",
                table: "cashierChecklist",
                column: "signatureId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_kitchenCheckList_aromaticsServer_aromaticsServerid",
                table: "kitchenCheckList",
                column: "aromaticsServerid",
                principalTable: "aromaticsServer",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
