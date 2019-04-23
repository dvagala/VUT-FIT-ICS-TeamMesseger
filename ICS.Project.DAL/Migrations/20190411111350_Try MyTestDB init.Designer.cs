﻿// <auto-generated />
using System;
using ICS.Project.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ICS.Project.BL.Migrations
{
    [DbContext(typeof(MessengerDbContext))]
    [Migration("20190411111350_Try MyTestDB init")]
    partial class TryMyTestDBinit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ICS.Project.DAL.Entities.CommentEntity", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("AuthorId");

                    b.Property<string>("MessageText");

                    b.Property<Guid?>("PostId");

                    b.Property<DateTime>("PublishDate");

                    b.HasKey("ID");

                    b.HasIndex("AuthorId");

                    b.HasIndex("PostId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("ICS.Project.DAL.Entities.PostEntity", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("AuthorId");

                    b.Property<string>("MessageText");

                    b.Property<DateTime>("PublishDate");

                    b.Property<string>("Title");

                    b.HasKey("ID");

                    b.HasIndex("AuthorId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("ICS.Project.DAL.Entities.TeamEntity", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("ICS.Project.DAL.Entities.UserEntity", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<DateTime>("LastActivity");

                    b.Property<string>("MessageText");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.Property<string>("Surname");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ICS.Project.DAL.Entities.UserInTeamEntity", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("TeamId");

                    b.Property<Guid?>("UserId");

                    b.HasKey("ID");

                    b.HasIndex("TeamId");

                    b.HasIndex("UserId");

                    b.ToTable("UserInTeam");
                });

            modelBuilder.Entity("ICS.Project.DAL.Entities.CommentEntity", b =>
                {
                    b.HasOne("ICS.Project.DAL.Entities.UserEntity", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId");

                    b.HasOne("ICS.Project.DAL.Entities.PostEntity", "Post")
                        .WithMany("Comments")
                        .HasForeignKey("PostId");
                });

            modelBuilder.Entity("ICS.Project.DAL.Entities.PostEntity", b =>
                {
                    b.HasOne("ICS.Project.DAL.Entities.UserEntity", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId");
                });

            modelBuilder.Entity("ICS.Project.DAL.Entities.UserInTeamEntity", b =>
                {
                    b.HasOne("ICS.Project.DAL.Entities.TeamEntity", "Team")
                        .WithMany("UsersInTeams")
                        .HasForeignKey("TeamId");

                    b.HasOne("ICS.Project.DAL.Entities.UserEntity", "User")
                        .WithMany("UsersInTeams")
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}