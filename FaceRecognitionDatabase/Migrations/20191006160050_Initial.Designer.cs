﻿// <auto-generated />
using System;
using FaceRecognitionDatabase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FaceRecognitionDatabase.Migrations
{
    [DbContext(typeof(FaceRecognitionContext))]
    [Migration("20191006160050_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FaceRecognitionDatabase.ImageLabel", b =>
                {
                    b.Property<int>("ImageLabelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Label")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ImageLabelId");

                    b.ToTable("ImageLabels");
                });

            modelBuilder.Entity("FaceRecognitionDatabase.LogCommand", b =>
                {
                    b.Property<int>("LogCommandId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CommandResult")
                        .HasColumnType("int");

                    b.Property<DateTime>("FinishCommandDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartCommandDate")
                        .HasColumnType("datetime2");

                    b.HasKey("LogCommandId");

                    b.ToTable("LogCommands");
                });

            modelBuilder.Entity("FaceRecognitionDatabase.LogRecognition", b =>
                {
                    b.Property<int>("LogRecognitionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("RecognitionConfidance")
                        .HasColumnType("float");

                    b.HasKey("LogRecognitionId");

                    b.ToTable("LogRecognitions");
                });

            modelBuilder.Entity("FaceRecognitionDatabase.UserLabel", b =>
                {
                    b.Property<int>("UserLabelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Label")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserLabelId");

                    b.ToTable("UserLabels");
                });
#pragma warning restore 612, 618
        }
    }
}
