﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using webapi.datacontext;

#nullable disable

namespace webapi.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("webapi.models.Comment", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("comment");
                });

            modelBuilder.Entity("webapi.models.Signature", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateOnly>("date")
                        .HasColumnType("date");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("signature");
                });

            modelBuilder.Entity("webapi.models.form.CashierChecklist", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("checkCash")
                        .HasColumnType("bit");

                    b.Property<Guid?>("commentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateOnly>("date")
                        .HasColumnType("date");

                    b.Property<bool>("ensureChange")
                        .HasColumnType("bit");

                    b.Property<bool>("ensurePrinter")
                        .HasColumnType("bit");

                    b.Property<Guid?>("signatureId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("tidyWorkstation")
                        .HasColumnType("bit");

                    b.HasKey("id");

                    b.HasIndex("commentId")
                        .IsUnique()
                        .HasFilter("[commentId] IS NOT NULL");

                    b.HasIndex("signatureId")
                        .IsUnique()
                        .HasFilter("[signatureId] IS NOT NULL");

                    b.ToTable("cashierChecklist");
                });

            modelBuilder.Entity("webapi.models.form.KitchenCheckList", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("commentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateOnly>("date")
                        .HasColumnType("date");

                    b.Property<Guid>("signatureId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("id");

                    b.HasIndex("commentId")
                        .IsUnique();

                    b.HasIndex("signatureId")
                        .IsUnique();

                    b.ToTable("kitchenCheckList");
                });

            modelBuilder.Entity("webapi.models.form.ServiceCheckList", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("commentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateOnly>("date")
                        .HasColumnType("date");

                    b.Property<Guid>("signatureId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("id");

                    b.HasIndex("commentId")
                        .IsUnique();

                    b.HasIndex("signatureId")
                        .IsUnique();

                    b.ToTable("serviceCheckList");
                });

            modelBuilder.Entity("webapi.models.form.StockOpeningCheckList", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("beverages")
                        .HasColumnType("bit");

                    b.Property<bool>("checkUtensils")
                        .HasColumnType("bit");

                    b.Property<bool>("coldCups")
                        .HasColumnType("bit");

                    b.Property<Guid>("commentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("condiments")
                        .HasColumnType("bit");

                    b.Property<DateOnly>("date")
                        .HasColumnType("date");

                    b.Property<bool>("ramenBar")
                        .HasColumnType("bit");

                    b.Property<Guid>("signatureId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("straws")
                        .HasColumnType("bit");

                    b.Property<bool>("takeoutBox")
                        .HasColumnType("bit");

                    b.Property<bool>("teaBags")
                        .HasColumnType("bit");

                    b.Property<bool>("tissues")
                        .HasColumnType("bit");

                    b.Property<bool>("tissuesPacks")
                        .HasColumnType("bit");

                    b.Property<bool>("towels")
                        .HasColumnType("bit");

                    b.HasKey("id");

                    b.HasIndex("commentId")
                        .IsUnique();

                    b.HasIndex("signatureId")
                        .IsUnique();

                    b.ToTable("stockOpeningCheckList");
                });

            modelBuilder.Entity("webapi.models.kitchen.Aromatics", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("listId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("prepAromatics")
                        .HasColumnType("bit");

                    b.Property<bool>("readyDeserts")
                        .HasColumnType("bit");

                    b.HasKey("id");

                    b.HasIndex("listId")
                        .IsUnique();

                    b.ToTable("aromatics");
                });

            modelBuilder.Entity("webapi.models.kitchen.ArrivalBasics", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("listId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("powerOnKitchenAcOnly")
                        .HasColumnType("bit");

                    b.Property<bool>("powerOnLights")
                        .HasColumnType("bit");

                    b.HasKey("id");

                    b.HasIndex("listId")
                        .IsUnique();

                    b.ToTable("arrivalBasics");
                });

            modelBuilder.Entity("webapi.models.kitchen.BrothPrep", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("boilBroths")
                        .HasColumnType("bit");

                    b.Property<bool>("fillPots")
                        .HasColumnType("bit");

                    b.Property<Guid>("listId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("monitorPots")
                        .HasColumnType("bit");

                    b.Property<bool>("prepVegetables")
                        .HasColumnType("bit");

                    b.Property<bool>("washMeats")
                        .HasColumnType("bit");

                    b.HasKey("id");

                    b.HasIndex("listId")
                        .IsUnique();

                    b.ToTable("brothPrep");
                });

            modelBuilder.Entity("webapi.models.kitchen.CleanRestaurantServer", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("fixFurniture")
                        .HasColumnType("bit");

                    b.Property<Guid>("listId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("sweep")
                        .HasColumnType("bit");

                    b.Property<bool>("wipeTables")
                        .HasColumnType("bit");

                    b.HasKey("id");

                    b.HasIndex("listId")
                        .IsUnique();

                    b.ToTable("cleanRestaurantServer");
                });

            modelBuilder.Entity("webapi.models.kitchen.FinalPrep", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("informServiceTeam")
                        .HasColumnType("bit");

                    b.Property<Guid>("listId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("readyStation")
                        .HasColumnType("bit");

                    b.HasKey("id");

                    b.HasIndex("listId")
                        .IsUnique();

                    b.ToTable("finalPrep");
                });

            modelBuilder.Entity("webapi.models.kitchen.FinalPrepServer", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("listId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("listUnavailableItem")
                        .HasColumnType("bit");

                    b.Property<bool>("openingStandup")
                        .HasColumnType("bit");

                    b.Property<bool>("turnOnTv")
                        .HasColumnType("bit");

                    b.HasKey("id");

                    b.HasIndex("listId")
                        .IsUnique();

                    b.ToTable("finalPrepServer");
                });

            modelBuilder.Entity("webapi.models.kitchen.PrepProteins", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("listId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("prepFish")
                        .HasColumnType("bit");

                    b.Property<bool>("prepMeatOrange")
                        .HasColumnType("bit");

                    b.Property<bool>("prepSkewers")
                        .HasColumnType("bit");

                    b.Property<bool>("prepTofu")
                        .HasColumnType("bit");

                    b.Property<bool>("prepWings")
                        .HasColumnType("bit");

                    b.Property<bool>("prepareChickenChashu")
                        .HasColumnType("bit");

                    b.Property<bool>("prepareChickenKatsu")
                        .HasColumnType("bit");

                    b.Property<bool>("prepareShrimpNobo")
                        .HasColumnType("bit");

                    b.Property<bool>("prepareShrimpTempura")
                        .HasColumnType("bit");

                    b.Property<bool>("prepareSousVideBeef")
                        .HasColumnType("bit");

                    b.Property<bool>("seasonSalmon")
                        .HasColumnType("bit");

                    b.HasKey("id");

                    b.HasIndex("listId")
                        .IsUnique();

                    b.ToTable("prepProteins");
                });

            modelBuilder.Entity("webapi.models.kitchen.PrepSauces", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("finishingSauce")
                        .HasColumnType("bit");

                    b.Property<Guid>("listId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("senseiSauce")
                        .HasColumnType("bit");

                    b.HasKey("id");

                    b.HasIndex("listId")
                        .IsUnique();

                    b.ToTable("prepSauces");
                });

            modelBuilder.Entity("webapi.models.kitchen.PrepSaucesServer", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("coconutWater")
                        .HasColumnType("bit");

                    b.Property<Guid>("listId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("id");

                    b.HasIndex("listId")
                        .IsUnique();

                    b.ToTable("prepSaucesServer");
                });

            modelBuilder.Entity("webapi.models.kitchen.SaladPrep", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("listId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("prepSaladVeg")
                        .HasColumnType("bit");

                    b.HasKey("id");

                    b.HasIndex("listId")
                        .IsUnique();

                    b.ToTable("saladPrep");
                });

            modelBuilder.Entity("webapi.models.kitchen.SaladPrepServer", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("listId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("stirSaladVegeServerLights")
                        .HasColumnType("bit");

                    b.Property<bool>("stirSalidVegeServerRemove")
                        .HasColumnType("bit");

                    b.HasKey("id");

                    b.HasIndex("listId")
                        .IsUnique();

                    b.ToTable("saladPrepServer");
                });

            modelBuilder.Entity("webapi.models.kitchen.StirFryVeg", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("listId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("stirFryVeg")
                        .HasColumnType("bit");

                    b.HasKey("id");

                    b.HasIndex("listId")
                        .IsUnique();

                    b.ToTable("stirFryVeg");
                });

            modelBuilder.Entity("webapi.models.kitchen.ToppingsPrep", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("blanchChoy")
                        .HasColumnType("bit");

                    b.Property<bool>("friedRicePrep")
                        .HasColumnType("bit");

                    b.Property<Guid>("listId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("id");

                    b.HasIndex("listId")
                        .IsUnique();

                    b.ToTable("toppingsPrep");
                });

            modelBuilder.Entity("webapi.models.service.AromaticsServer", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("cleanGlass")
                        .HasColumnType("bit");

                    b.Property<Guid>("listId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("id");

                    b.HasIndex("listId")
                        .IsUnique();

                    b.ToTable("aromaticsServer");
                });

            modelBuilder.Entity("webapi.models.form.CashierChecklist", b =>
                {
                    b.HasOne("webapi.models.Comment", "comment")
                        .WithOne()
                        .HasForeignKey("webapi.models.form.CashierChecklist", "commentId");

                    b.HasOne("webapi.models.Signature", "signature")
                        .WithOne()
                        .HasForeignKey("webapi.models.form.CashierChecklist", "signatureId");

                    b.Navigation("comment");

                    b.Navigation("signature");
                });

            modelBuilder.Entity("webapi.models.form.KitchenCheckList", b =>
                {
                    b.HasOne("webapi.models.Comment", "comment")
                        .WithOne()
                        .HasForeignKey("webapi.models.form.KitchenCheckList", "commentId");

                    b.HasOne("webapi.models.Signature", "signature")
                        .WithOne()
                        .HasForeignKey("webapi.models.form.KitchenCheckList", "signatureId");

                    b.Navigation("comment");

                    b.Navigation("signature");
                });

            modelBuilder.Entity("webapi.models.form.ServiceCheckList", b =>
                {
                    b.HasOne("webapi.models.Comment", "comment")
                        .WithOne()
                        .HasForeignKey("webapi.models.form.ServiceCheckList", "commentId");

                    b.HasOne("webapi.models.Signature", "signature")
                        .WithOne()
                        .HasForeignKey("webapi.models.form.ServiceCheckList", "signatureId");

                    b.Navigation("comment");

                    b.Navigation("signature");
                });

            modelBuilder.Entity("webapi.models.form.StockOpeningCheckList", b =>
                {
                    b.HasOne("webapi.models.Comment", "comment")
                        .WithOne()
                        .HasForeignKey("webapi.models.form.StockOpeningCheckList", "commentId");

                    b.HasOne("webapi.models.Signature", "signature")
                        .WithOne()
                        .HasForeignKey("webapi.models.form.StockOpeningCheckList", "signatureId");

                    b.Navigation("comment");

                    b.Navigation("signature");
                });

            modelBuilder.Entity("webapi.models.kitchen.Aromatics", b =>
                {
                    b.HasOne("webapi.models.form.KitchenCheckList", null)
                        .WithOne("aromatics")
                        .HasForeignKey("webapi.models.kitchen.Aromatics", "listId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("webapi.models.kitchen.ArrivalBasics", b =>
                {
                    b.HasOne("webapi.models.form.KitchenCheckList", null)
                        .WithOne("arrivalBasics")
                        .HasForeignKey("webapi.models.kitchen.ArrivalBasics", "listId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("webapi.models.kitchen.BrothPrep", b =>
                {
                    b.HasOne("webapi.models.form.KitchenCheckList", null)
                        .WithOne("brothPrep")
                        .HasForeignKey("webapi.models.kitchen.BrothPrep", "listId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("webapi.models.kitchen.CleanRestaurantServer", b =>
                {
                    b.HasOne("webapi.models.form.ServiceCheckList", null)
                        .WithOne("cleanRestaurantServer")
                        .HasForeignKey("webapi.models.kitchen.CleanRestaurantServer", "listId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("webapi.models.kitchen.FinalPrep", b =>
                {
                    b.HasOne("webapi.models.form.KitchenCheckList", null)
                        .WithOne("finalPrep")
                        .HasForeignKey("webapi.models.kitchen.FinalPrep", "listId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("webapi.models.kitchen.FinalPrepServer", b =>
                {
                    b.HasOne("webapi.models.form.ServiceCheckList", null)
                        .WithOne("finalPrepServer")
                        .HasForeignKey("webapi.models.kitchen.FinalPrepServer", "listId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("webapi.models.kitchen.PrepProteins", b =>
                {
                    b.HasOne("webapi.models.form.KitchenCheckList", null)
                        .WithOne("prepProteins")
                        .HasForeignKey("webapi.models.kitchen.PrepProteins", "listId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("webapi.models.kitchen.PrepSauces", b =>
                {
                    b.HasOne("webapi.models.form.KitchenCheckList", null)
                        .WithOne("prepSauces")
                        .HasForeignKey("webapi.models.kitchen.PrepSauces", "listId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("webapi.models.kitchen.PrepSaucesServer", b =>
                {
                    b.HasOne("webapi.models.form.ServiceCheckList", null)
                        .WithOne("prepSaucesServer")
                        .HasForeignKey("webapi.models.kitchen.PrepSaucesServer", "listId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("webapi.models.kitchen.SaladPrep", b =>
                {
                    b.HasOne("webapi.models.form.KitchenCheckList", null)
                        .WithOne("saladPrep")
                        .HasForeignKey("webapi.models.kitchen.SaladPrep", "listId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("webapi.models.kitchen.SaladPrepServer", b =>
                {
                    b.HasOne("webapi.models.form.ServiceCheckList", null)
                        .WithOne("saladPrepServer")
                        .HasForeignKey("webapi.models.kitchen.SaladPrepServer", "listId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("webapi.models.kitchen.StirFryVeg", b =>
                {
                    b.HasOne("webapi.models.form.KitchenCheckList", null)
                        .WithOne("stirFryVeg")
                        .HasForeignKey("webapi.models.kitchen.StirFryVeg", "listId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("webapi.models.kitchen.ToppingsPrep", b =>
                {
                    b.HasOne("webapi.models.form.KitchenCheckList", null)
                        .WithOne("toppingsPrep")
                        .HasForeignKey("webapi.models.kitchen.ToppingsPrep", "listId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("webapi.models.service.AromaticsServer", b =>
                {
                    b.HasOne("webapi.models.form.ServiceCheckList", null)
                        .WithOne("aromaticsServer")
                        .HasForeignKey("webapi.models.service.AromaticsServer", "listId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("webapi.models.form.KitchenCheckList", b =>
                {
                    b.Navigation("aromatics")
                        .IsRequired();

                    b.Navigation("arrivalBasics")
                        .IsRequired();

                    b.Navigation("brothPrep")
                        .IsRequired();

                    b.Navigation("finalPrep")
                        .IsRequired();

                    b.Navigation("prepProteins")
                        .IsRequired();

                    b.Navigation("prepSauces")
                        .IsRequired();

                    b.Navigation("saladPrep")
                        .IsRequired();

                    b.Navigation("stirFryVeg")
                        .IsRequired();

                    b.Navigation("toppingsPrep")
                        .IsRequired();
                });

            modelBuilder.Entity("webapi.models.form.ServiceCheckList", b =>
                {
                    b.Navigation("aromaticsServer")
                        .IsRequired();

                    b.Navigation("cleanRestaurantServer")
                        .IsRequired();

                    b.Navigation("finalPrepServer")
                        .IsRequired();

                    b.Navigation("prepSaucesServer")
                        .IsRequired();

                    b.Navigation("saladPrepServer")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
