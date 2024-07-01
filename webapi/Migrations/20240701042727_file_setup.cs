using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webapi.Migrations
{
    /// <inheritdoc />
    public partial class file_setup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "fileData",
                table: "fileType");

            migrationBuilder.DropColumn(
                name: "uploadedAt",
                table: "fileType");

            migrationBuilder.RenameColumn(
                name: "fileType",
                table: "fileType",
                newName: "path");

            migrationBuilder.RenameColumn(
                name: "file",
                table: "fileType",
                newName: "name");

            migrationBuilder.AlterColumn<Guid>(
                name: "listId",
                table: "fileType",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "path",
                table: "fileType",
                newName: "fileType");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "fileType",
                newName: "file");

            migrationBuilder.AlterColumn<Guid>(
                name: "listId",
                table: "fileType",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "fileData",
                table: "fileType",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<DateTime>(
                name: "uploadedAt",
                table: "fileType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
