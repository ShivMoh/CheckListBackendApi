using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webapi.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "comment",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    comment = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_comment", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "fileContainerType",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fileContainerType", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "listReferenceType",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_listReferenceType", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "signature",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_signature", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "fileType",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    path = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    label = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    filesContainerTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    listReferenceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fileType", x => x.id);
                    table.ForeignKey(
                        name: "FK_fileType_fileContainerType_filesContainerTypeId",
                        column: x => x.filesContainerTypeId,
                        principalTable: "fileContainerType",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_fileType_listReferenceType_listReferenceId",
                        column: x => x.listReferenceId,
                        principalTable: "listReferenceType",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "cashierChecklist",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    startDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    endDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    commentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    signatureId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    listReferenceTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    submitted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cashierChecklist", x => x.id);
                    table.ForeignKey(
                        name: "FK_cashierChecklist_comment_commentId",
                        column: x => x.commentId,
                        principalTable: "comment",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_cashierChecklist_listReferenceType_listReferenceTypeId",
                        column: x => x.listReferenceTypeId,
                        principalTable: "listReferenceType",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cashierChecklist_signature_signatureId",
                        column: x => x.signatureId,
                        principalTable: "signature",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "kitchenCheckList",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    startDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    endDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    commentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    signatureId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    listReferenceTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    submitted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kitchenCheckList", x => x.id);
                    table.ForeignKey(
                        name: "FK_kitchenCheckList_comment_commentId",
                        column: x => x.commentId,
                        principalTable: "comment",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_kitchenCheckList_listReferenceType_listReferenceTypeId",
                        column: x => x.listReferenceTypeId,
                        principalTable: "listReferenceType",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_kitchenCheckList_signature_signatureId",
                        column: x => x.signatureId,
                        principalTable: "signature",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "serviceCheckList",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    startDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    endDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    commentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    signatureId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    listReferenceTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    submitted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_serviceCheckList", x => x.id);
                    table.ForeignKey(
                        name: "FK_serviceCheckList_comment_commentId",
                        column: x => x.commentId,
                        principalTable: "comment",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_serviceCheckList_listReferenceType_listReferenceTypeId",
                        column: x => x.listReferenceTypeId,
                        principalTable: "listReferenceType",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_serviceCheckList_signature_signatureId",
                        column: x => x.signatureId,
                        principalTable: "signature",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "stockOpeningCheckList",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    startDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    endDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    commentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    signatureId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    listReferenceTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    submitted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stockOpeningCheckList", x => x.id);
                    table.ForeignKey(
                        name: "FK_stockOpeningCheckList_comment_commentId",
                        column: x => x.commentId,
                        principalTable: "comment",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_stockOpeningCheckList_listReferenceType_listReferenceTypeId",
                        column: x => x.listReferenceTypeId,
                        principalTable: "listReferenceType",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_stockOpeningCheckList_signature_signatureId",
                        column: x => x.signatureId,
                        principalTable: "signature",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "cashierTask",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    checkCash = table.Column<bool>(type: "bit", nullable: false),
                    ensureChange = table.Column<bool>(type: "bit", nullable: false),
                    ensurePrinter = table.Column<bool>(type: "bit", nullable: false),
                    tidyWorkstation = table.Column<bool>(type: "bit", nullable: false),
                    listId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    fileContainerTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cashierTask", x => x.id);
                    table.ForeignKey(
                        name: "FK_cashierTask_cashierChecklist_listId",
                        column: x => x.listId,
                        principalTable: "cashierChecklist",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cashierTask_fileContainerType_fileContainerTypeId",
                        column: x => x.fileContainerTypeId,
                        principalTable: "fileContainerType",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "aromatics",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    prepAromatics = table.Column<bool>(type: "bit", nullable: false),
                    readyDeserts = table.Column<bool>(type: "bit", nullable: false),
                    listId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    fileContainerTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aromatics", x => x.id);
                    table.ForeignKey(
                        name: "FK_aromatics_fileContainerType_fileContainerTypeId",
                        column: x => x.fileContainerTypeId,
                        principalTable: "fileContainerType",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_aromatics_kitchenCheckList_listId",
                        column: x => x.listId,
                        principalTable: "kitchenCheckList",
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
                    listId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    fileContainerTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_arrivalBasics", x => x.id);
                    table.ForeignKey(
                        name: "FK_arrivalBasics_fileContainerType_fileContainerTypeId",
                        column: x => x.fileContainerTypeId,
                        principalTable: "fileContainerType",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_arrivalBasics_kitchenCheckList_listId",
                        column: x => x.listId,
                        principalTable: "kitchenCheckList",
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
                    listId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    fileContainerTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_brothPrep", x => x.id);
                    table.ForeignKey(
                        name: "FK_brothPrep_fileContainerType_fileContainerTypeId",
                        column: x => x.fileContainerTypeId,
                        principalTable: "fileContainerType",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_brothPrep_kitchenCheckList_listId",
                        column: x => x.listId,
                        principalTable: "kitchenCheckList",
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
                    listId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    fileContainerTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_finalPrep", x => x.id);
                    table.ForeignKey(
                        name: "FK_finalPrep_fileContainerType_fileContainerTypeId",
                        column: x => x.fileContainerTypeId,
                        principalTable: "fileContainerType",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_finalPrep_kitchenCheckList_listId",
                        column: x => x.listId,
                        principalTable: "kitchenCheckList",
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
                    listId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    fileContainerTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prepProteins", x => x.id);
                    table.ForeignKey(
                        name: "FK_prepProteins_fileContainerType_fileContainerTypeId",
                        column: x => x.fileContainerTypeId,
                        principalTable: "fileContainerType",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_prepProteins_kitchenCheckList_listId",
                        column: x => x.listId,
                        principalTable: "kitchenCheckList",
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
                    listId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    fileContainerTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prepSauces", x => x.id);
                    table.ForeignKey(
                        name: "FK_prepSauces_fileContainerType_fileContainerTypeId",
                        column: x => x.fileContainerTypeId,
                        principalTable: "fileContainerType",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_prepSauces_kitchenCheckList_listId",
                        column: x => x.listId,
                        principalTable: "kitchenCheckList",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "saladPrep",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    prepSaladVeg = table.Column<bool>(type: "bit", nullable: false),
                    listId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    fileContainerTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_saladPrep", x => x.id);
                    table.ForeignKey(
                        name: "FK_saladPrep_fileContainerType_fileContainerTypeId",
                        column: x => x.fileContainerTypeId,
                        principalTable: "fileContainerType",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_saladPrep_kitchenCheckList_listId",
                        column: x => x.listId,
                        principalTable: "kitchenCheckList",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "stirFryVeg",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    stirFryVeg = table.Column<bool>(type: "bit", nullable: false),
                    listId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    fileContainerTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stirFryVeg", x => x.id);
                    table.ForeignKey(
                        name: "FK_stirFryVeg_fileContainerType_fileContainerTypeId",
                        column: x => x.fileContainerTypeId,
                        principalTable: "fileContainerType",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_stirFryVeg_kitchenCheckList_listId",
                        column: x => x.listId,
                        principalTable: "kitchenCheckList",
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
                    listId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    fileContainerTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_toppingsPrep", x => x.id);
                    table.ForeignKey(
                        name: "FK_toppingsPrep_fileContainerType_fileContainerTypeId",
                        column: x => x.fileContainerTypeId,
                        principalTable: "fileContainerType",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_toppingsPrep_kitchenCheckList_listId",
                        column: x => x.listId,
                        principalTable: "kitchenCheckList",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "aromaticsServer",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    cleanGlass = table.Column<bool>(type: "bit", nullable: false),
                    listId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    fileContainerTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aromaticsServer", x => x.id);
                    table.ForeignKey(
                        name: "FK_aromaticsServer_fileContainerType_fileContainerTypeId",
                        column: x => x.fileContainerTypeId,
                        principalTable: "fileContainerType",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_aromaticsServer_serviceCheckList_listId",
                        column: x => x.listId,
                        principalTable: "serviceCheckList",
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
                    listId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    fileContainerTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cleanRestaurantServer", x => x.id);
                    table.ForeignKey(
                        name: "FK_cleanRestaurantServer_fileContainerType_fileContainerTypeId",
                        column: x => x.fileContainerTypeId,
                        principalTable: "fileContainerType",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cleanRestaurantServer_serviceCheckList_listId",
                        column: x => x.listId,
                        principalTable: "serviceCheckList",
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
                    listUnavailableItems = table.Column<bool>(type: "bit", nullable: false),
                    listId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    fileContainerTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_finalPrepServer", x => x.id);
                    table.ForeignKey(
                        name: "FK_finalPrepServer_fileContainerType_fileContainerTypeId",
                        column: x => x.fileContainerTypeId,
                        principalTable: "fileContainerType",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_finalPrepServer_serviceCheckList_listId",
                        column: x => x.listId,
                        principalTable: "serviceCheckList",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "prepSaucesServer",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    coconutWater = table.Column<bool>(type: "bit", nullable: false),
                    listId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    fileContainerTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prepSaucesServer", x => x.id);
                    table.ForeignKey(
                        name: "FK_prepSaucesServer_fileContainerType_fileContainerTypeId",
                        column: x => x.fileContainerTypeId,
                        principalTable: "fileContainerType",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_prepSaucesServer_serviceCheckList_listId",
                        column: x => x.listId,
                        principalTable: "serviceCheckList",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "saladPrepServer",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    stirSaladVegeServerLights = table.Column<bool>(type: "bit", nullable: false),
                    stirSaladVegeServerRemove = table.Column<bool>(type: "bit", nullable: false),
                    listId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    fileContainerTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_saladPrepServer", x => x.id);
                    table.ForeignKey(
                        name: "FK_saladPrepServer_fileContainerType_fileContainerTypeId",
                        column: x => x.fileContainerTypeId,
                        principalTable: "fileContainerType",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_saladPrepServer_serviceCheckList_listId",
                        column: x => x.listId,
                        principalTable: "serviceCheckList",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "stockTask",
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
                    listId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    fileContainerTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stockTask", x => x.id);
                    table.ForeignKey(
                        name: "FK_stockTask_fileContainerType_fileContainerTypeId",
                        column: x => x.fileContainerTypeId,
                        principalTable: "fileContainerType",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_stockTask_stockOpeningCheckList_listId",
                        column: x => x.listId,
                        principalTable: "stockOpeningCheckList",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_aromatics_fileContainerTypeId",
                table: "aromatics",
                column: "fileContainerTypeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_aromatics_listId",
                table: "aromatics",
                column: "listId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_aromaticsServer_fileContainerTypeId",
                table: "aromaticsServer",
                column: "fileContainerTypeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_aromaticsServer_listId",
                table: "aromaticsServer",
                column: "listId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_arrivalBasics_fileContainerTypeId",
                table: "arrivalBasics",
                column: "fileContainerTypeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_arrivalBasics_listId",
                table: "arrivalBasics",
                column: "listId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_brothPrep_fileContainerTypeId",
                table: "brothPrep",
                column: "fileContainerTypeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_brothPrep_listId",
                table: "brothPrep",
                column: "listId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_cashierChecklist_commentId",
                table: "cashierChecklist",
                column: "commentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_cashierChecklist_listReferenceTypeId",
                table: "cashierChecklist",
                column: "listReferenceTypeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_cashierChecklist_signatureId",
                table: "cashierChecklist",
                column: "signatureId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_cashierTask_fileContainerTypeId",
                table: "cashierTask",
                column: "fileContainerTypeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_cashierTask_listId",
                table: "cashierTask",
                column: "listId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_cleanRestaurantServer_fileContainerTypeId",
                table: "cleanRestaurantServer",
                column: "fileContainerTypeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_cleanRestaurantServer_listId",
                table: "cleanRestaurantServer",
                column: "listId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_fileType_filesContainerTypeId",
                table: "fileType",
                column: "filesContainerTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_fileType_listReferenceId",
                table: "fileType",
                column: "listReferenceId");

            migrationBuilder.CreateIndex(
                name: "IX_finalPrep_fileContainerTypeId",
                table: "finalPrep",
                column: "fileContainerTypeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_finalPrep_listId",
                table: "finalPrep",
                column: "listId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_finalPrepServer_fileContainerTypeId",
                table: "finalPrepServer",
                column: "fileContainerTypeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_finalPrepServer_listId",
                table: "finalPrepServer",
                column: "listId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_kitchenCheckList_commentId",
                table: "kitchenCheckList",
                column: "commentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_kitchenCheckList_listReferenceTypeId",
                table: "kitchenCheckList",
                column: "listReferenceTypeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_kitchenCheckList_signatureId",
                table: "kitchenCheckList",
                column: "signatureId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_prepProteins_fileContainerTypeId",
                table: "prepProteins",
                column: "fileContainerTypeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_prepProteins_listId",
                table: "prepProteins",
                column: "listId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_prepSauces_fileContainerTypeId",
                table: "prepSauces",
                column: "fileContainerTypeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_prepSauces_listId",
                table: "prepSauces",
                column: "listId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_prepSaucesServer_fileContainerTypeId",
                table: "prepSaucesServer",
                column: "fileContainerTypeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_prepSaucesServer_listId",
                table: "prepSaucesServer",
                column: "listId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_saladPrep_fileContainerTypeId",
                table: "saladPrep",
                column: "fileContainerTypeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_saladPrep_listId",
                table: "saladPrep",
                column: "listId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_saladPrepServer_fileContainerTypeId",
                table: "saladPrepServer",
                column: "fileContainerTypeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_saladPrepServer_listId",
                table: "saladPrepServer",
                column: "listId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_serviceCheckList_commentId",
                table: "serviceCheckList",
                column: "commentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_serviceCheckList_listReferenceTypeId",
                table: "serviceCheckList",
                column: "listReferenceTypeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_serviceCheckList_signatureId",
                table: "serviceCheckList",
                column: "signatureId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_stirFryVeg_fileContainerTypeId",
                table: "stirFryVeg",
                column: "fileContainerTypeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_stirFryVeg_listId",
                table: "stirFryVeg",
                column: "listId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_stockOpeningCheckList_commentId",
                table: "stockOpeningCheckList",
                column: "commentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_stockOpeningCheckList_listReferenceTypeId",
                table: "stockOpeningCheckList",
                column: "listReferenceTypeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_stockOpeningCheckList_signatureId",
                table: "stockOpeningCheckList",
                column: "signatureId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_stockTask_fileContainerTypeId",
                table: "stockTask",
                column: "fileContainerTypeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_stockTask_listId",
                table: "stockTask",
                column: "listId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_toppingsPrep_fileContainerTypeId",
                table: "toppingsPrep",
                column: "fileContainerTypeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_toppingsPrep_listId",
                table: "toppingsPrep",
                column: "listId",
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
                name: "cashierTask");

            migrationBuilder.DropTable(
                name: "cleanRestaurantServer");

            migrationBuilder.DropTable(
                name: "fileType");

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
                name: "stirFryVeg");

            migrationBuilder.DropTable(
                name: "stockTask");

            migrationBuilder.DropTable(
                name: "toppingsPrep");

            migrationBuilder.DropTable(
                name: "cashierChecklist");

            migrationBuilder.DropTable(
                name: "serviceCheckList");

            migrationBuilder.DropTable(
                name: "stockOpeningCheckList");

            migrationBuilder.DropTable(
                name: "fileContainerType");

            migrationBuilder.DropTable(
                name: "kitchenCheckList");

            migrationBuilder.DropTable(
                name: "comment");

            migrationBuilder.DropTable(
                name: "listReferenceType");

            migrationBuilder.DropTable(
                name: "signature");
        }
    }
}
