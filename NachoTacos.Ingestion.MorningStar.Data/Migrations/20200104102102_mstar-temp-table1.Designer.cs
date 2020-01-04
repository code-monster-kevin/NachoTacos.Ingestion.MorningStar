﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NachoTacos.Ingestion.MorningStar.Data;

namespace NachoTacos.Ingestion.MorningStar.Data.Migrations
{
    [DbContext(typeof(IngestionContext))]
    [Migration("20200104102102_mstar-temp-table1")]
    partial class mstartemptable1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NachoTacos.Ingestion.MorningStar.Domain.ClientConfiguration", b =>
                {
                    b.Property<Guid>("ClientConfigurationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AccountLogin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccountPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LoginUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClientConfigurationId");

                    b.ToTable("ClientConfigurations");
                });

            modelBuilder.Entity("NachoTacos.Ingestion.MorningStar.Domain.IngestionResult", b =>
                {
                    b.Property<Guid>("IngestionResultId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PostData")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Processed")
                        .HasColumnType("bit");

                    b.Property<string>("ResponseData")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SourceType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SourceUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("IngestionResultId");

                    b.ToTable("IngestionResults");
                });

            modelBuilder.Entity("NachoTacos.Ingestion.MorningStar.Domain.IngestionTask", b =>
                {
                    b.Property<Guid>("IngestionTaskId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Entity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsProcessed")
                        .HasColumnType("bit");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("IngestionTaskId");

                    b.ToTable("IngestionTasks");
                });

            modelBuilder.Entity("NachoTacos.Ingestion.MorningStar.Domain.TStockExchangeSecurity", b =>
                {
                    b.Property<string>("CIK")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CUSIP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DelistingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DelistingReason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExchangeId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExchangeSubMarketGlobalId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ISIN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("IngestionTaskId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("InvestmentTypeId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ParValue")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("SEDOL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StockStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SuspendedFlag")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Symbol")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("TStockExchangeSecurity","MStar");
                });
#pragma warning restore 612, 618
        }
    }
}
