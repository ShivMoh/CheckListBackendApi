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
            migrationBuilder.CreateTable(
                name: "mainList",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mainList", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "aromatics",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    prepAromatics = table.Column<bool>(type: "bit", nullable: false),
                    readyDeserts = table.Column<bool>(type: "bit", nullable: false),
                    mainListId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aromatics", x => x.id);
                    table.ForeignKey(
                        name: "FK_aromatics_mainList_mainListId",
                        column: x => x.mainListId,
                        principalTable: "mainList",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "aromaticsServer",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    cleanGlass = table.Column<bool>(type: "bit", nullable: false),
                    mainListId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aromaticsServer", x => x.id);
                    table.ForeignKey(
                        name: "FK_aromaticsServer_mainList_mainListId",
                        column: x => x.mainListId,
                        principalTable: "mainList",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "arrivalBasics",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    powerOnLights = table.Column<bool>(type: "bit", nullable: false),
                    powerOnKitchenAcOnly = table.Column<bool>(type: "bit", nullable: false),
                    mainListId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_arrivalBasics", x => x.id);
                    table.ForeignKey(
                        name: "FK_arrivalBasics_mainList_mainListId",
                        column: x => x.mainListId,
                        principalTable: "mainList",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "brothPrep",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    washMeats = table.Column<bool>(type: "bit", nullable: false),
                    fillPots = table.Column<bool>(type: "bit", nullable: false),
                    prepVegetables = table.Column<bool>(type: "bit", nullable: false),
                    monitorPots = table.Column<bool>(type: "bit", nullable: false),
                    boilBroths = table.Column<bool>(type: "bit", nullable: false),
                    mainListId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_brothPrep", x => x.id);
                    table.ForeignKey(
                        name: "FK_brothPrep_mainList_mainListId",
                        column: x => x.mainListId,
                        principalTable: "mainList",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "cashierChecklist",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    checkCash = table.Column<bool>(type: "bit", nullable: false),
                    ensureChange = table.Column<bool>(type: "bit", nullable: false),
                    ensurePrinter = table.Column<bool>(type: "bit", nullable: false),
                    tidyWorkstation = table.Column<bool>(type: "bit", nullable: false),
                    mainListId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cashierChecklist", x => x.id);
                    table.ForeignKey(
                        name: "FK_cashierChecklist_mainList_mainListId",
                        column: x => x.mainListId,
                        principalTable: "mainList",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "cleanRestaurantServer",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    sweep = table.Column<bool>(type: "bit", nullable: false),
                    wipeTables = table.Column<bool>(type: "bit", nullable: false),
                    fixFurniture = table.Column<bool>(type: "bit", nullable: false),
                    mainListId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cleanRestaurantServer", x => x.id);
                    table.ForeignKey(
                        name: "FK_cleanRestaurantServer_mainList_mainListId",
                        column: x => x.mainListId,
                        principalTable: "mainList",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "finalPrep",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    informServiceTeam = table.Column<bool>(type: "bit", nullable: false),
                    readyStation = table.Column<bool>(type: "bit", nullable: false),
                    mainListId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_finalPrep", x => x.id);
                    table.ForeignKey(
                        name: "FK_finalPrep_mainList_mainListId",
                        column: x => x.mainListId,
                        principalTable: "mainList",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "finalPrepServer",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    turnOnTv = table.Column<bool>(type: "bit", nullable: false),
                    openingStandup = table.Column<bool>(type: "bit", nullable: false),
                    listUnavailableItem = table.Column<bool>(type: "bit", nullable: false),
                    mainListId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_finalPrepServer", x => x.id);
                    table.ForeignKey(
                        name: "FK_finalPrepServer_mainList_mainListId",
                        column: x => x.mainListId,
                        principalTable: "mainList",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "prepProteins",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    prepFish = table.Column<bool>(type: "bit", nullable: false),
                    prepMeatOrange = table.Column<bool>(type: "bit", nullable: false),
                    prepSkewers = table.Column<bool>(type: "bit", nullable: false),
                    prepTofu = table.Column<bool>(type: "bit", nullable: false),
                    prepWings = table.Column<bool>(type: "bit", nullable: false),
                    prepareChickenChashu = table.Column<bool>(type: "bit", nullable: false),
                    prepareChickenKatsu = table.Column<bool>(type: "bit", nullable: false),
                    prepareShrimpNobo = table.Column<bool>(type: "bit", nullable: false),
                    prepareShrimpTempura = table.Column<bool>(type: "bit", nullable: false),
                    prepareSousVideBeef = table.Column<bool>(type: "bit", nullable: false),
                    seasonSalmon = table.Column<bool>(type: "bit", nullable: false),
                    mainListId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prepProteins", x => x.id);
                    table.ForeignKey(
                        name: "FK_prepProteins_mainList_mainListId",
                        column: x => x.mainListId,
                        principalTable: "mainList",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "prepSauces",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    senseiSauce = table.Column<bool>(type: "bit", nullable: false),
                    finishingSauce = table.Column<bool>(type: "bit", nullable: false),
                    mainListId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prepSauces", x => x.id);
                    table.ForeignKey(
                        name: "FK_prepSauces_mainList_mainListId",
                        column: x => x.mainListId,
                        principalTable: "mainList",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "prepSaucesServer",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    coconutWater = table.Column<bool>(type: "bit", nullable: false),
                    mainListId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prepSaucesServer", x => x.id);
                    table.ForeignKey(
                        name: "FK_prepSaucesServer_mainList_mainListId",
                        column: x => x.mainListId,
                        principalTable: "mainList",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "saladPrep",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    prepSaladVeg = table.Column<bool>(type: "bit", nullable: false),
                    mainListId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_saladPrep", x => x.id);
                    table.ForeignKey(
                        name: "FK_saladPrep_mainList_mainListId",
                        column: x => x.mainListId,
                        principalTable: "mainList",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "saladPrepServer",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    stirSaladVegeServerLights = table.Column<bool>(type: "bit", nullable: false),
                    stirSalidVegeServerRemove = table.Column<bool>(type: "bit", nullable: false),
                    mainListId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_saladPrepServer", x => x.id);
                    table.ForeignKey(
                        name: "FK_saladPrepServer_mainList_mainListId",
                        column: x => x.mainListId,
                        principalTable: "mainList",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Signature",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    kitchenName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    serviceName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    kitchenDate = table.Column<DateOnly>(type: "date", nullable: false),
                    serviceDate = table.Column<DateOnly>(type: "date", nullable: false),
                    mainListId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Signature", x => x.id);
                    table.ForeignKey(
                        name: "FK_Signature_mainList_mainListId",
                        column: x => x.mainListId,
                        principalTable: "mainList",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "stirFryVeg",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    stirFryVeg = table.Column<bool>(type: "bit", nullable: false),
                    mainListId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stirFryVeg", x => x.id);
                    table.ForeignKey(
                        name: "FK_stirFryVeg_mainList_mainListId",
                        column: x => x.mainListId,
                        principalTable: "mainList",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "stockOpeningCheckList",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    beverages = table.Column<bool>(type: "bit", nullable: false),
                    checkUtensils = table.Column<bool>(type: "bit", nullable: false),
                    coldCups = table.Column<bool>(type: "bit", nullable: false),
                    condiments = table.Column<bool>(type: "bit", nullable: false),
                    ramenBar = table.Column<bool>(type: "bit", nullable: false),
                    straws = table.Column<bool>(type: "bit", nullable: false),
                    takeoutBox = table.Column<bool>(type: "bit", nullable: false),
                    teaBags = table.Column<bool>(type: "bit", nullable: false),
                    tissues = table.Column<bool>(type: "bit", nullable: false),
                    tissuesPacks = table.Column<bool>(type: "bit", nullable: false),
                    towels = table.Column<bool>(type: "bit", nullable: false),
                    mainListId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stockOpeningCheckList", x => x.id);
                    table.ForeignKey(
                        name: "FK_stockOpeningCheckList_mainList_mainListId",
                        column: x => x.mainListId,
                        principalTable: "mainList",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "toppingsPrep",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    blanchChoy = table.Column<bool>(type: "bit", nullable: false),
                    friedRicePrep = table.Column<bool>(type: "bit", nullable: false),
                    mainListId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_toppingsPrep", x => x.id);
                    table.ForeignKey(
                        name: "FK_toppingsPrep_mainList_mainListId",
                        column: x => x.mainListId,
                        principalTable: "mainList",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_aromatics_mainListId",
                table: "aromatics",
                column: "mainListId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_aromaticsServer_mainListId",
                table: "aromaticsServer",
                column: "mainListId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_arrivalBasics_mainListId",
                table: "arrivalBasics",
                column: "mainListId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_brothPrep_mainListId",
                table: "brothPrep",
                column: "mainListId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_cashierChecklist_mainListId",
                table: "cashierChecklist",
                column: "mainListId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_cleanRestaurantServer_mainListId",
                table: "cleanRestaurantServer",
                column: "mainListId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_finalPrep_mainListId",
                table: "finalPrep",
                column: "mainListId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_finalPrepServer_mainListId",
                table: "finalPrepServer",
                column: "mainListId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_prepProteins_mainListId",
                table: "prepProteins",
                column: "mainListId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_prepSauces_mainListId",
                table: "prepSauces",
                column: "mainListId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_prepSaucesServer_mainListId",
                table: "prepSaucesServer",
                column: "mainListId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_saladPrep_mainListId",
                table: "saladPrep",
                column: "mainListId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_saladPrepServer_mainListId",
                table: "saladPrepServer",
                column: "mainListId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Signature_mainListId",
                table: "Signature",
                column: "mainListId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_stirFryVeg_mainListId",
                table: "stirFryVeg",
                column: "mainListId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_stockOpeningCheckList_mainListId",
                table: "stockOpeningCheckList",
                column: "mainListId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_toppingsPrep_mainListId",
                table: "toppingsPrep",
                column: "mainListId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "aromatics");

            migrationBuilder.DropTable(
                name: "aromaticsServer");

            migrationBuilder.DropTable(
                name: "arrivalBasics");

            migrationBuilder.DropTable(
                name: "brothPrep");

            migrationBuilder.DropTable(
                name: "cashierChecklist");

            migrationBuilder.DropTable(
                name: "cleanRestaurantServer");

            migrationBuilder.DropTable(
                name: "finalPrep");

            migrationBuilder.DropTable(
                name: "finalPrepServer");

            migrationBuilder.DropTable(
                name: "prepProteins");

            migrationBuilder.DropTable(
                name: "prepSauces");

            migrationBuilder.DropTable(
                name: "prepSaucesServer");

            migrationBuilder.DropTable(
                name: "saladPrep");

            migrationBuilder.DropTable(
                name: "saladPrepServer");

            migrationBuilder.DropTable(
                name: "Signature");

            migrationBuilder.DropTable(
                name: "stirFryVeg");

            migrationBuilder.DropTable(
                name: "stockOpeningCheckList");

            migrationBuilder.DropTable(
                name: "toppingsPrep");

            migrationBuilder.DropTable(
                name: "mainList");
        }
    }
}
