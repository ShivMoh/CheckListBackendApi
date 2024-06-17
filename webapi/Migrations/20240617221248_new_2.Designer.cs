﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using webapi.datacontext;

#nullable disable

namespace webapi.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240617221248_new_2")]
    partial class new_2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("web.models.MainList", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("id");

                    b.ToTable("mainList");
                });

            modelBuilder.Entity("webapi.models.kitchen.Aromatics", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("mainListId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("id");

                    b.HasIndex("mainListId")
                        .IsUnique();

                    b.ToTable("aromatics");
                });

            modelBuilder.Entity("webapi.models.kitchen.ArrivalBasics", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("mainListId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("id");

                    b.HasIndex("mainListId")
                        .IsUnique();

                    b.ToTable("ArrivalBasics");
                });

            modelBuilder.Entity("webapi.models.kitchen.BrothPrep", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("mainListId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("id");

                    b.HasIndex("mainListId")
                        .IsUnique();

                    b.ToTable("BrothPrep");
                });

            modelBuilder.Entity("webapi.models.kitchen.CleanRestaurantServer", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("mainListId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("id");

                    b.HasIndex("mainListId")
                        .IsUnique();

                    b.ToTable("CleanRestaurantServer");
                });

            modelBuilder.Entity("webapi.models.kitchen.FinalPrep", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("mainListId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("id");

                    b.HasIndex("mainListId")
                        .IsUnique();

                    b.ToTable("FinalPrep");
                });

            modelBuilder.Entity("webapi.models.kitchen.FinalPrepServer", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("mainListId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("id");

                    b.HasIndex("mainListId")
                        .IsUnique();

                    b.ToTable("FinalPrepServer");
                });

            modelBuilder.Entity("webapi.models.kitchen.PrepProteins", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("mainListId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("id");

                    b.HasIndex("mainListId")
                        .IsUnique();

                    b.ToTable("PrepProteins");
                });

            modelBuilder.Entity("webapi.models.kitchen.PrepSauces", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("mainListId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("id");

                    b.HasIndex("mainListId")
                        .IsUnique();

                    b.ToTable("PrepSauces");
                });

            modelBuilder.Entity("webapi.models.kitchen.PrepSaucesServer", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("mainListId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("id");

                    b.HasIndex("mainListId")
                        .IsUnique();

                    b.ToTable("PrepSaucesServer");
                });

            modelBuilder.Entity("webapi.models.kitchen.SaladPrep", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("mainListId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("id");

                    b.HasIndex("mainListId")
                        .IsUnique();

                    b.ToTable("SaladPrep");
                });

            modelBuilder.Entity("webapi.models.kitchen.SaladPrepServer", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("mainListId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("id");

                    b.HasIndex("mainListId")
                        .IsUnique();

                    b.ToTable("SaladPrepServer");
                });

            modelBuilder.Entity("webapi.models.kitchen.StirFryVeg", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("mainListId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("id");

                    b.HasIndex("mainListId")
                        .IsUnique();

                    b.ToTable("StirFryVeg");
                });

            modelBuilder.Entity("webapi.models.kitchen.ToppingsPrep", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("mainListId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("id");

                    b.HasIndex("mainListId")
                        .IsUnique();

                    b.ToTable("ToppingsPrep");
                });

            modelBuilder.Entity("webapi.models.service.AromaticServer", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("mainListId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("id");

                    b.HasIndex("mainListId")
                        .IsUnique();

                    b.ToTable("AromaticServer");
                });

            modelBuilder.Entity("webapi.models.kitchen.Aromatics", b =>
                {
                    b.HasOne("web.models.MainList", "mainList")
                        .WithOne("aromatics")
                        .HasForeignKey("webapi.models.kitchen.Aromatics", "mainListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("mainList");
                });

            modelBuilder.Entity("webapi.models.kitchen.ArrivalBasics", b =>
                {
                    b.HasOne("web.models.MainList", "mainList")
                        .WithOne("arrivalBasics")
                        .HasForeignKey("webapi.models.kitchen.ArrivalBasics", "mainListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("mainList");
                });

            modelBuilder.Entity("webapi.models.kitchen.BrothPrep", b =>
                {
                    b.HasOne("web.models.MainList", "mainList")
                        .WithOne("brothPrep")
                        .HasForeignKey("webapi.models.kitchen.BrothPrep", "mainListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("mainList");
                });

            modelBuilder.Entity("webapi.models.kitchen.CleanRestaurantServer", b =>
                {
                    b.HasOne("web.models.MainList", "mainList")
                        .WithOne("cleanRestaurantServer")
                        .HasForeignKey("webapi.models.kitchen.CleanRestaurantServer", "mainListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("mainList");
                });

            modelBuilder.Entity("webapi.models.kitchen.FinalPrep", b =>
                {
                    b.HasOne("web.models.MainList", "mainList")
                        .WithOne("finalPrep")
                        .HasForeignKey("webapi.models.kitchen.FinalPrep", "mainListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("mainList");
                });

            modelBuilder.Entity("webapi.models.kitchen.FinalPrepServer", b =>
                {
                    b.HasOne("web.models.MainList", "mainList")
                        .WithOne("finalPrepServer")
                        .HasForeignKey("webapi.models.kitchen.FinalPrepServer", "mainListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("mainList");
                });

            modelBuilder.Entity("webapi.models.kitchen.PrepProteins", b =>
                {
                    b.HasOne("web.models.MainList", "mainList")
                        .WithOne("prepProteins")
                        .HasForeignKey("webapi.models.kitchen.PrepProteins", "mainListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("mainList");
                });

            modelBuilder.Entity("webapi.models.kitchen.PrepSauces", b =>
                {
                    b.HasOne("web.models.MainList", "mainList")
                        .WithOne("prepSauces")
                        .HasForeignKey("webapi.models.kitchen.PrepSauces", "mainListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("mainList");
                });

            modelBuilder.Entity("webapi.models.kitchen.PrepSaucesServer", b =>
                {
                    b.HasOne("web.models.MainList", "mainList")
                        .WithOne("prepSaucesServer")
                        .HasForeignKey("webapi.models.kitchen.PrepSaucesServer", "mainListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("mainList");
                });

            modelBuilder.Entity("webapi.models.kitchen.SaladPrep", b =>
                {
                    b.HasOne("web.models.MainList", "mainList")
                        .WithOne("saladPrep")
                        .HasForeignKey("webapi.models.kitchen.SaladPrep", "mainListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("mainList");
                });

            modelBuilder.Entity("webapi.models.kitchen.SaladPrepServer", b =>
                {
                    b.HasOne("web.models.MainList", "mainList")
                        .WithOne("saladPrepServer")
                        .HasForeignKey("webapi.models.kitchen.SaladPrepServer", "mainListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("mainList");
                });

            modelBuilder.Entity("webapi.models.kitchen.StirFryVeg", b =>
                {
                    b.HasOne("web.models.MainList", "mainList")
                        .WithOne("stirFryVeg")
                        .HasForeignKey("webapi.models.kitchen.StirFryVeg", "mainListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("mainList");
                });

            modelBuilder.Entity("webapi.models.kitchen.ToppingsPrep", b =>
                {
                    b.HasOne("web.models.MainList", "mainList")
                        .WithOne("toppingsPrep")
                        .HasForeignKey("webapi.models.kitchen.ToppingsPrep", "mainListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("mainList");
                });

            modelBuilder.Entity("webapi.models.service.AromaticServer", b =>
                {
                    b.HasOne("web.models.MainList", "mainList")
                        .WithOne("aromaticServer")
                        .HasForeignKey("webapi.models.service.AromaticServer", "mainListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("mainList");
                });

            modelBuilder.Entity("web.models.MainList", b =>
                {
                    b.Navigation("aromaticServer")
                        .IsRequired();

                    b.Navigation("aromatics")
                        .IsRequired();

                    b.Navigation("arrivalBasics")
                        .IsRequired();

                    b.Navigation("brothPrep")
                        .IsRequired();

                    b.Navigation("cleanRestaurantServer")
                        .IsRequired();

                    b.Navigation("finalPrep")
                        .IsRequired();

                    b.Navigation("finalPrepServer")
                        .IsRequired();

                    b.Navigation("prepProteins")
                        .IsRequired();

                    b.Navigation("prepSauces")
                        .IsRequired();

                    b.Navigation("prepSaucesServer")
                        .IsRequired();

                    b.Navigation("saladPrep")
                        .IsRequired();

                    b.Navigation("saladPrepServer")
                        .IsRequired();

                    b.Navigation("stirFryVeg")
                        .IsRequired();

                    b.Navigation("toppingsPrep")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
