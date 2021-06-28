﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PsDevs.Data;

namespace PsDevs.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210627133207_CareerApplicationModelAdded")]
    partial class CareerApplicationModelAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PsDevs.Models.Career", b =>
                {
                    b.Property<int>("CareerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CareerDatePosted")
                        .HasColumnType("datetime2");

                    b.Property<string>("CareerDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CareerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CareerType")
                        .HasColumnType("int");

                    b.Property<string>("CareerYearsExperience")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CareerId");

                    b.ToTable("Careers");
                });

            modelBuilder.Entity("PsDevs.Models.TeamMember", b =>
                {
                    b.Property<int>("TeamMemberId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TeamMemberImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeamMemberName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeamMemberPosition")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeamMemberId");

                    b.ToTable("TeamMembers");

                    b.HasData(
                        new
                        {
                            TeamMemberId = 1,
                            TeamMemberImageUrl = "https://images.unsplash.com/photo-1586083702768-190ae093d34d?ixid=MnwxMjA3fDB8MHxzZWFyY2h8OXx8bWFufGVufDB8fDB8fA%3D%3D&ixlib=rb-1.2.1&w=1000&q=80",
                            TeamMemberName = "PLEASURE NDHLOVU",
                            TeamMemberPosition = "FOUNDER"
                        },
                        new
                        {
                            TeamMemberId = 2,
                            TeamMemberImageUrl = "https://images.unsplash.com/photo-1560241804-02b7b1bc9d55?ixid=MnwxMjA3fDB8MHxzZWFyY2h8Nnx8bWFufGVufDB8fDB8fA%3D%3D&ixlib=rb-1.2.1&w=1000&q=80",
                            TeamMemberName = "SURPRISE MDLULI",
                            TeamMemberPosition = "CO-FOUNDER"
                        },
                        new
                        {
                            TeamMemberId = 3,
                            TeamMemberImageUrl = "https://i.pinimg.com/originals/b5/d3/54/b5d354063dae4723a18195174019fc73.jpg",
                            TeamMemberName = "SAM JONE",
                            TeamMemberPosition = "ARCHITECTURE"
                        },
                        new
                        {
                            TeamMemberId = 4,
                            TeamMemberImageUrl = "https://images.unsplash.com/photo-1544005313-94ddf0286df2?ixid=MnwxMjA3fDB8MHxzZWFyY2h8OXx8cGVyc29ufGVufDB8fDB8fA%3D%3D&ixlib=rb-1.2.1&w=1000&q=80",
                            TeamMemberName = "ABIGAIL MNISI",
                            TeamMemberPosition = "SENIOR DEVELOPER"
                        },
                        new
                        {
                            TeamMemberId = 5,
                            TeamMemberImageUrl = "https://images.unsplash.com/photo-1570158268183-d296b2892211?ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTd8fGJsYWNrJTIwbWFsZXxlbnwwfHwwfHw%3D&ixlib=rb-1.2.1&w=1000&q=80",
                            TeamMemberName = "PRINCE THWALA",
                            TeamMemberPosition = "SENIOR DEVELOPER"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
