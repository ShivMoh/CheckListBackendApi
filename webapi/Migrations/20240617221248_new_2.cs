using System;
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
            migrationBuilder.CreateTable(
                name: "AromaticServer",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    mainListId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AromaticServer", x => x.id);
                    table.ForeignKey(
                        name: "FK_AromaticServer_mainList_mainListId",
                        column: x => x.mainListId,
                        principalTable: "mainList",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArrivalBasics",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    mainListId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArrivalBasics", x => x.id);
                    table.ForeignKey(
                        name: "FK_ArrivalBasics_mainList_mainListId",
                        column: x => x.mainListId,
                        principalTable: "mainList",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BrothPrep",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    mainListId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrothPrep", x => x.id);
                    table.ForeignKey(
                        name: "FK_BrothPrep_mainList_mainListId",
                        column: x => x.mainListId,
                        principalTable: "mainList",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CleanRestaurantServer",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    mainListId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CleanRestaurantServer", x => x.id);
                    table.ForeignKey(
                        name: "FK_CleanRestaurantServer_mainList_mainListId",
                        column: x => x.mainListId,
                        principalTable: "mainList",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FinalPrep",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    mainListId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinalPrep", x => x.id);
                    table.ForeignKey(
                        name: "FK_FinalPrep_mainList_mainListId",
                        column: x => x.mainListId,
                        principalTable: "mainList",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FinalPrepServer",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    mainListId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinalPrepServer", x => x.id);
                    table.ForeignKey(
                        name: "FK_FinalPrepServer_mainList_mainListId",
                        column: x => x.mainListId,
                        principalTable: "mainList",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PrepProteins",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    mainListId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrepProteins", x => x.id);
                    table.ForeignKey(
                        name: "FK_PrepProteins_mainList_mainListId",
                        column: x => x.mainListId,
                        principalTable: "mainList",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PrepSauces",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    mainListId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrepSauces", x => x.id);
                    table.ForeignKey(
                        name: "FK_PrepSauces_mainList_mainListId",
                        column: x => x.mainListId,
                        principalTable: "mainList",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PrepSaucesServer",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    mainListId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrepSaucesServer", x => x.id);
                    table.ForeignKey(
                        name: "FK_PrepSaucesServer_mainList_mainListId",
                        column: x => x.mainListId,
                        principalTable: "mainList",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SaladPrep",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    mainListId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaladPrep", x => x.id);
                    table.ForeignKey(
                        name: "FK_SaladPrep_mainList_mainListId",
                        column: x => x.mainListId,
                        principalTable: "mainList",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SaladPrepServer",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    mainListId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaladPrepServer", x => x.id);
                    table.ForeignKey(
                        name: "FK_SaladPrepServer_mainList_mainListId",
                        column: x => x.mainListId,
                        principalTable: "mainList",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StirFryVeg",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    mainListId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StirFryVeg", x => x.id);
                    table.ForeignKey(
                        name: "FK_StirFryVeg_mainList_mainListId",
                        column: x => x.mainListId,
                        principalTable: "mainList",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ToppingsPrep",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    mainListId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToppingsPrep", x => x.id);
                    table.ForeignKey(
                        name: "FK_ToppingsPrep_mainList_mainListId",
                        column: x => x.mainListId,
                        principalTable: "mainList",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AromaticServer_mainListId",
                table: "AromaticServer",
                column: "mainListId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ArrivalBasics_mainListId",
                table: "ArrivalBasics",
                column: "mainListId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BrothPrep_mainListId",
                table: "BrothPrep",
                column: "mainListId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CleanRestaurantServer_mainListId",
                table: "CleanRestaurantServer",
                column: "mainListId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FinalPrep_mainListId",
                table: "FinalPrep",
                column: "mainListId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FinalPrepServer_mainListId",
                table: "FinalPrepServer",
                column: "mainListId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PrepProteins_mainListId",
                table: "PrepProteins",
                column: "mainListId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PrepSauces_mainListId",
                table: "PrepSauces",
                column: "mainListId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PrepSaucesServer_mainListId",
                table: "PrepSaucesServer",
                column: "mainListId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SaladPrep_mainListId",
                table: "SaladPrep",
                column: "mainListId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SaladPrepServer_mainListId",
                table: "SaladPrepServer",
                column: "mainListId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StirFryVeg_mainListId",
                table: "StirFryVeg",
                column: "mainListId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ToppingsPrep_mainListId",
                table: "ToppingsPrep",
                column: "mainListId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AromaticServer");

            migrationBuilder.DropTable(
                name: "ArrivalBasics");

            migrationBuilder.DropTable(
                name: "BrothPrep");

            migrationBuilder.DropTable(
                name: "CleanRestaurantServer");

            migrationBuilder.DropTable(
                name: "FinalPrep");

            migrationBuilder.DropTable(
                name: "FinalPrepServer");

            migrationBuilder.DropTable(
                name: "PrepProteins");

            migrationBuilder.DropTable(
                name: "PrepSauces");

            migrationBuilder.DropTable(
                name: "PrepSaucesServer");

            migrationBuilder.DropTable(
                name: "SaladPrep");

            migrationBuilder.DropTable(
                name: "SaladPrepServer");

            migrationBuilder.DropTable(
                name: "StirFryVeg");

            migrationBuilder.DropTable(
                name: "ToppingsPrep");
        }
    }
}
