﻿// <auto-generated />
using System;
using ICS.Project.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ICS.Project.DAL.Migrations
{
    [DbContext(typeof(MessengerDbContext))]
    [Migration("20190503213852_change seed student hash")]
    partial class changeseedstudenthash
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

                    b.HasData(
                        new
                        {
                            ID = new Guid("dc16e27a-07e2-0f47-b09d-0f362003ca85"),
                            AuthorId = new Guid("ec16e27a-47e2-4f47-b19d-1a362003ca85"),
                            MessageText = "Pro eu tation saperet, et sea brute similique theophrastus. Nec ex verear facilisi conceptam, novum postulant definitiones mei at.",
                            PostId = new Guid("ec16e28b-07e2-0f47-b19d-0b362003ca85"),
                            PublishDate = new DateTime(2019, 2, 1, 5, 12, 4, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = new Guid("dc16e27a-07e2-0f47-b19d-0f362003ca85"),
                            AuthorId = new Guid("ec16e27a-47e2-4f47-b19d-2a362003ca85"),
                            MessageText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                            PostId = new Guid("ec16e28b-07e2-0f47-b19d-0b362003ca85"),
                            PublishDate = new DateTime(2019, 2, 3, 4, 17, 40, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = new Guid("dc16e27a-07e2-0f47-b29d-0f362003ca85"),
                            AuthorId = new Guid("ec16e27a-47e2-4f47-b19d-0a362003ca85"),
                            MessageText = "Partem scripta laoreet ei cum. Ea vel dico vocibus omittam, pro mollis tamquam efficiendi an.",
                            PostId = new Guid("ec16e28b-07e2-0f47-b19d-0b362003ca85"),
                            PublishDate = new DateTime(2019, 3, 10, 11, 19, 31, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = new Guid("dc16e27a-07e2-0f47-b39d-0f362003ca85"),
                            AuthorId = new Guid("ec16e27a-47e2-4f47-b19d-3a362003ca85"),
                            MessageText = "Mel at viris fuisset, vis diceret meliore ut.",
                            PostId = new Guid("ec16e28b-07e2-0f47-b19d-0b362003ca85"),
                            PublishDate = new DateTime(2019, 3, 10, 11, 20, 39, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = new Guid("dc16e27a-07e2-4f47-b49d-0f362003ca85"),
                            AuthorId = new Guid("ec16e27a-47e2-4f47-b19d-3a362003ca85"),
                            MessageText = "Nec iudico soluta vocent id, qui ferri perfecto te. Quo id tota dicam volumus.",
                            PostId = new Guid("ec16e28b-17e2-4f47-b19d-0b362003ca85"),
                            PublishDate = new DateTime(2019, 3, 1, 1, 14, 2, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = new Guid("dc16e27a-07e2-4f47-b59d-0f362003ca85"),
                            AuthorId = new Guid("ec16e27a-47e2-4f47-b19d-2a362003ca85"),
                            MessageText = "Quo clita quaeque id, ei vel invenire persecuti.",
                            PostId = new Guid("ec16e28b-17e2-4f47-b19d-0b362003ca85"),
                            PublishDate = new DateTime(2019, 3, 1, 2, 4, 20, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = new Guid("dc16e27a-07e2-1f47-b69d-0f362003ca85"),
                            AuthorId = new Guid("ec16e27a-47e2-4f47-b19d-2a362003ca85"),
                            MessageText = "o exerci nonumes has, sit in sumo assum dissentias.",
                            PostId = new Guid("ec16e28b-07e2-1f47-b19d-0b362003ca85"),
                            PublishDate = new DateTime(2019, 1, 1, 7, 14, 50, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = new Guid("dc16e27a-07e2-1f47-b79d-0f362003ca85"),
                            AuthorId = new Guid("ec16e27a-47e2-4f47-b19d-1a362003ca85"),
                            MessageText = "Altera abhorreant referrentur eam ut, ne pro purto meis dolor.",
                            PostId = new Guid("ec16e28b-07e2-1f47-b19d-0b362003ca85"),
                            PublishDate = new DateTime(2019, 1, 1, 7, 15, 50, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = new Guid("dc16e27a-07e2-2f47-b89d-0f362003ca85"),
                            AuthorId = new Guid("ec16e27a-47e2-4f47-b19d-2a362003ca85"),
                            MessageText = "Ad his pertinacia assueverit conclusionemque.",
                            PostId = new Guid("ec16e28b-17e2-2f47-b19d-0b362003ca85"),
                            PublishDate = new DateTime(2019, 2, 12, 7, 13, 52, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("ICS.Project.DAL.Entities.PostEntity", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("AuthorId");

                    b.Property<string>("MessageText");

                    b.Property<DateTime>("PublishDate");

                    b.Property<Guid?>("TeamId");

                    b.Property<string>("Title");

                    b.HasKey("ID");

                    b.HasIndex("AuthorId");

                    b.HasIndex("TeamId");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            ID = new Guid("ec16e28b-07e2-0f47-b19d-0b362003ca85"),
                            AuthorId = new Guid("ec16e27a-47e2-4f47-b19d-0a362003ca85"),
                            MessageText = "Quo clita quaeque id, ei vel invenire persecuti.",
                            PublishDate = new DateTime(2019, 2, 1, 3, 31, 12, 0, DateTimeKind.Unspecified),
                            TeamId = new Guid("ec16e27a-07e2-4f47-b19d-0a362003ca85"),
                            Title = "Mediocrem"
                        },
                        new
                        {
                            ID = new Guid("ec16e28b-17e2-4f47-b19d-0b362003ca85"),
                            AuthorId = new Guid("ec16e27a-47e2-4f47-b19d-1a362003ca85"),
                            MessageText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                            PublishDate = new DateTime(2019, 3, 1, 1, 8, 54, 0, DateTimeKind.Unspecified),
                            TeamId = new Guid("ec16e27a-07e2-4f47-b19d-0a362003ca85"),
                            Title = "Novum"
                        },
                        new
                        {
                            ID = new Guid("ec16e28b-27e2-4f47-b19d-0b362003ca85"),
                            AuthorId = new Guid("ec16e27a-47e2-4f47-b19d-2a362003ca85"),
                            MessageText = "Pro eu tation saperet, et sea brute similique theophrastus. Nec ex verear facilisi conceptam, novum postulant definitiones mei at.",
                            PublishDate = new DateTime(2019, 5, 14, 18, 21, 7, 0, DateTimeKind.Unspecified),
                            TeamId = new Guid("ec16e27a-07e2-4f47-b19d-0a362003ca85"),
                            Title = "Euismod"
                        },
                        new
                        {
                            ID = new Guid("ec16e28b-07e2-1f47-b19d-0b362003ca85"),
                            AuthorId = new Guid("ec16e27a-47e2-4f47-b19d-1a362003ca85"),
                            MessageText = "Partem scripta laoreet ei cum. Ea vel dico vocibus omittam, pro mollis tamquam efficiendi an.",
                            PublishDate = new DateTime(2019, 1, 1, 8, 36, 50, 0, DateTimeKind.Unspecified),
                            TeamId = new Guid("ec16e27a-17e2-4f47-b19d-0a362003ca85"),
                            Title = "Splendide"
                        },
                        new
                        {
                            ID = new Guid("ec16e28b-17e2-2f47-b19d-0b362003ca85"),
                            AuthorId = new Guid("ec16e27a-47e2-4f47-b19d-0a362003ca85"),
                            MessageText = "Mel at viris fuisset, vis diceret meliore ut.",
                            PublishDate = new DateTime(2019, 2, 1, 12, 13, 50, 0, DateTimeKind.Unspecified),
                            TeamId = new Guid("ec16e27a-17e2-4f47-b19d-0a362003ca85"),
                            Title = "Imperdiet"
                        },
                        new
                        {
                            ID = new Guid("ec16e28b-07e2-4f47-b19d-0b362003ca85"),
                            AuthorId = new Guid("ec16e27a-47e2-4f47-b19d-3a362003ca85"),
                            MessageText = "Nec iudico soluta vocent id, qui ferri perfecto te. Quo id tota dicam volumus.",
                            PublishDate = new DateTime(2019, 4, 1, 7, 13, 50, 0, DateTimeKind.Unspecified),
                            TeamId = new Guid("ec16e27a-27e2-4f47-b19d-0a362003ca85"),
                            Title = "Putent"
                        });
                });

            modelBuilder.Entity("ICS.Project.DAL.Entities.TeamEntity", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Teams");

                    b.HasData(
                        new
                        {
                            ID = new Guid("ec16e27a-07e2-4f47-b19d-0a362003ca85"),
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                            Name = "The Lewd Turtles"
                        },
                        new
                        {
                            ID = new Guid("ec16e27a-17e2-4f47-b19d-0a362003ca85"),
                            Description = "Pro eu tation saperet, et sea brute similique theophrastus. Nec ex verear facilisi conceptam, novum postulant definitiones mei at.",
                            Name = "Black Wariors"
                        },
                        new
                        {
                            ID = new Guid("ec16e27a-27e2-4f47-b19d-0a362003ca85"),
                            Description = "Partem scripta laoreet ei cum. Ea vel dico vocibus omittam, pro mollis tamquam efficiendi an.",
                            Name = "The Six Eagles"
                        },
                        new
                        {
                            ID = new Guid("ec16e27a-37e2-4f47-b19d-0a362003ca85"),
                            Description = "Mel at viris fuisset, vis diceret meliore ut.",
                            Name = "The Jagged Penguins"
                        });
                });

            modelBuilder.Entity("ICS.Project.DAL.Entities.UserEntity", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<bool>("IsLoggedIn");

                    b.Property<int>("IterationCount");

                    b.Property<DateTime>("LastLogoutTime");

                    b.Property<string>("Name");

                    b.Property<byte[]>("PasswordHash");

                    b.Property<byte[]>("Salt");

                    b.Property<string>("Surname");

                    b.HasKey("ID");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            ID = new Guid("ec16e27a-47e2-4f47-b19d-0a362003ca85"),
                            Email = "student@fit",
                            IsLoggedIn = false,
                            IterationCount = 10007,
                            LastLogoutTime = new DateTime(2019, 4, 4, 14, 13, 50, 0, DateTimeKind.Unspecified),
                            Name = "Student",
                            PasswordHash = new byte[] { 202, 82, 20, 32, 112, 253, 84, 38, 27, 97, 23, 217, 243, 164, 66, 10 },
                            Salt = new byte[] { 163, 239, 2, 208, 228, 143, 175, 191, 180, 132, 51, 246, 231, 59, 71, 67, 111, 210, 241, 123, 21, 17, 125, 143, 167, 195, 204, 109, 188, 100, 47, 255 },
                            Surname = "Roberts"
                        },
                        new
                        {
                            ID = new Guid("ec16e27a-47e2-4f47-b19d-1a362003ca85"),
                            IsLoggedIn = false,
                            IterationCount = 0,
                            LastLogoutTime = new DateTime(2019, 4, 18, 18, 47, 24, 0, DateTimeKind.Unspecified),
                            Name = "Regan",
                            Surname = "Wiggins"
                        },
                        new
                        {
                            ID = new Guid("ec16e27a-47e2-4f47-b19d-2a362003ca85"),
                            IsLoggedIn = false,
                            IterationCount = 0,
                            LastLogoutTime = new DateTime(2019, 3, 24, 14, 55, 36, 0, DateTimeKind.Unspecified),
                            Name = "Kimberl",
                            Surname = "Cohen"
                        },
                        new
                        {
                            ID = new Guid("ec16e27a-47e2-4f47-b19d-3a362003ca85"),
                            IsLoggedIn = false,
                            IterationCount = 0,
                            LastLogoutTime = new DateTime(2019, 4, 28, 14, 24, 11, 0, DateTimeKind.Unspecified),
                            Name = "Kelley",
                            Surname = "Watts"
                        });
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

                    b.HasData(
                        new
                        {
                            ID = new Guid("0c16e27a-07e2-4f47-b19d-0a362003ca85"),
                            TeamId = new Guid("ec16e27a-07e2-4f47-b19d-0a362003ca85"),
                            UserId = new Guid("ec16e27a-47e2-4f47-b19d-0a362003ca85")
                        },
                        new
                        {
                            ID = new Guid("1c16e27a-07e2-4f47-b19d-0a362003ca85"),
                            TeamId = new Guid("ec16e27a-17e2-4f47-b19d-0a362003ca85"),
                            UserId = new Guid("ec16e27a-47e2-4f47-b19d-0a362003ca85")
                        },
                        new
                        {
                            ID = new Guid("2c16e27a-07e2-4f47-b19d-0a362003ca85"),
                            TeamId = new Guid("ec16e27a-27e2-4f47-b19d-0a362003ca85"),
                            UserId = new Guid("ec16e27a-47e2-4f47-b19d-0a362003ca85")
                        },
                        new
                        {
                            ID = new Guid("3c16e27a-07e2-4f47-b19d-0a362003ca85"),
                            TeamId = new Guid("ec16e27a-37e2-4f47-b19d-0a362003ca85"),
                            UserId = new Guid("ec16e27a-47e2-4f47-b19d-0a362003ca85")
                        },
                        new
                        {
                            ID = new Guid("4c16e27a-07e2-4f47-b19d-0a362003ca85"),
                            TeamId = new Guid("ec16e27a-07e2-4f47-b19d-0a362003ca85"),
                            UserId = new Guid("ec16e27a-47e2-4f47-b19d-1a362003ca85")
                        },
                        new
                        {
                            ID = new Guid("5c16e27a-07e2-4f47-b19d-0a362003ca85"),
                            TeamId = new Guid("ec16e27a-07e2-4f47-b19d-0a362003ca85"),
                            UserId = new Guid("ec16e27a-47e2-4f47-b19d-2a362003ca85")
                        },
                        new
                        {
                            ID = new Guid("6c16e27a-07e2-4f47-b19d-0a362003ca85"),
                            TeamId = new Guid("ec16e27a-07e2-4f47-b19d-0a362003ca85"),
                            UserId = new Guid("ec16e27a-47e2-4f47-b19d-3a362003ca85")
                        },
                        new
                        {
                            ID = new Guid("7c16e27a-07e2-4f47-b19d-0a362003ca85"),
                            TeamId = new Guid("ec16e27a-17e2-4f47-b19d-0a362003ca85"),
                            UserId = new Guid("ec16e27a-47e2-4f47-b19d-1a362003ca85")
                        },
                        new
                        {
                            ID = new Guid("8c16e27a-07e2-4f47-b19d-0a362003ca85"),
                            TeamId = new Guid("ec16e27a-17e2-4f47-b19d-0a362003ca85"),
                            UserId = new Guid("ec16e27a-47e2-4f47-b19d-2a362003ca85")
                        },
                        new
                        {
                            ID = new Guid("9c16e27a-07e2-4f47-b19d-0a362003ca85"),
                            TeamId = new Guid("ec16e27a-27e2-4f47-b19d-0a362003ca85"),
                            UserId = new Guid("ec16e27a-47e2-4f47-b19d-3a362003ca85")
                        });
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

                    b.HasOne("ICS.Project.DAL.Entities.TeamEntity", "Team")
                        .WithMany()
                        .HasForeignKey("TeamId");
                });

            modelBuilder.Entity("ICS.Project.DAL.Entities.UserInTeamEntity", b =>
                {
                    b.HasOne("ICS.Project.DAL.Entities.TeamEntity", "Team")
                        .WithMany()
                        .HasForeignKey("TeamId");

                    b.HasOne("ICS.Project.DAL.Entities.UserEntity", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}