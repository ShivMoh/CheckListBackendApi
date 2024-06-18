using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webapi.Migrations
{
    /// <inheritdoc />
    public partial class new_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Signature_mainList_mainListId",
                table: "Signature");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Signature",
                table: "Signature");

            migrationBuilder.RenameTable(
                name: "Signature",
                newName: "signature");

            migrationBuilder.RenameIndex(
                name: "IX_Signature_mainListId",
                table: "signature",
                newName: "IX_signature_mainListId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_signature",
                table: "signature",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_signature_mainList_mainListId",
                table: "signature",
                column: "mainListId",
                principalTable: "mainList",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_signature_mainList_mainListId",
                table: "signature");

            migrationBuilder.DropPrimaryKey(
                name: "PK_signature",
                table: "signature");

            migrationBuilder.RenameTable(
                name: "signature",
                newName: "Signature");

            migrationBuilder.RenameIndex(
                name: "IX_signature_mainListId",
                table: "Signature",
                newName: "IX_Signature_mainListId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Signature",
                table: "Signature",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Signature_mainList_mainListId",
                table: "Signature",
                column: "mainListId",
                principalTable: "mainList",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
