using System;
using ICS.Project.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace ICS.Project.DAL
{
    public class MessengerDbContext : DbContext
    {
        public MessengerDbContext()
        {
        }

        public MessengerDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<CommentEntity> Comments { get; set; }
        public DbSet<PostEntity> Posts { get; set; }
        public DbSet<TeamEntity> Teams { get; set; }
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<UserInTeamEntity> UserInTeam { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var loremIpsum1 =
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.";
            var loremIpsum2 =
                "Pro eu tation saperet, et sea brute similique theophrastus. Nec ex verear facilisi conceptam, novum postulant definitiones mei at.";
            var loremIpsum3 =
                "Partem scripta laoreet ei cum. Ea vel dico vocibus omittam, pro mollis tamquam efficiendi an.";
            var loremIpsum4 =
                "Mel at viris fuisset, vis diceret meliore ut.";
            var loremIpsum5 =
                "Nec iudico soluta vocent id, qui ferri perfecto te. Quo id tota dicam volumus.";
            var loremIpsum6 =
                "Quo clita quaeque id, ei vel invenire persecuti.";
            var loremIpsum7 =
                "o exerci nonumes has, sit in sumo assum dissentias.";
            var loremIpsum8 =
                "Altera abhorreant referrentur eam ut, ne pro purto meis dolor.";
            var loremIpsum9 =
                "Ad his pertinacia assueverit conclusionemque.";

            // Generated for password 'student'
            byte[] salt =
            {
                116, 214, 110, 237, 125, 7, 30, 5, 219, 149, 182, 93, 62, 91, 71, 69, 105, 152, 66, 44, 114, 122, 219,
                28, 219, 147, 127, 133, 67, 116, 206, 143
            };
            byte[] hash = {19, 36, 234, 204, 83, 41, 69, 76, 27, 40, 176, 157, 35, 181, 37, 35};


            Guid user1 = new Guid("ec16e27a-47e2-4f47-b19d-0a362003ca83");
            Guid user2 = new Guid("ec16e27a-47e2-4f47-b19d-1a362003ca83");
            Guid user3 = new Guid("ec16e27a-47e2-4f47-b19d-2a362003ca83");
            Guid user4 = new Guid("ec16e27a-47e2-4f47-b19d-3a362003ca83");

            modelBuilder.Entity<UserEntity>().HasData(new UserEntity
            {
                ID = user1, Name = "Student", Surname = "Roberts",
                Email = "student@fit", PasswordHash = hash,
                Salt = salt,
                IterationCount = 10007
            }, new UserEntity
            {
                ID = user2,
                Name = "Regan",
                Surname = "Wiggins"
            }, new UserEntity
            {
                ID = user3,
                Name = "Kimberl",
                Surname = "Cohen"
            }, new UserEntity
            {
                ID = user4,
                Name = "Kelley",
                Surname = "Watts"
            });

            Guid team1 = new Guid("ec16e27a-07e2-4f47-b19d-0a362003ca83");
            Guid team2 = new Guid("ec16e27a-17e2-4f47-b19d-0a362003ca83");
            Guid team3 = new Guid("ec16e27a-27e2-4f47-b19d-0a362003ca83");
            Guid team4 = new Guid("ec16e27a-37e2-4f47-b19d-0a362003ca83");

            modelBuilder.Entity<TeamEntity>()
                .HasData(new TeamEntity
                {
                    ID = team1,
                    Name = "The Lewd Turtles",
                    Description = loremIpsum1
                }, new TeamEntity
                {
                    ID = team2,
                    Name = "Black Wariors",
                    Description = loremIpsum2
                }, new TeamEntity
                {
                    ID = team3,
                    Name = "The Six Eagles",
                    Description = loremIpsum3
                }, new TeamEntity
                {
                    ID = team4,
                    Name = "The Jagged Penguins",
                    Description = loremIpsum4
                });

            modelBuilder.Entity<UserInTeamEntity>().HasData(new UserInTeamEntity
                {
                    ID = new Guid("709ece27-ac92-4d56-a8aa-2016fa63a6eb"),
                    UserId = user1,
                    TeamId = team1
                }, new UserInTeamEntity
                {
                    ID = new Guid("719ece27-ac92-4d56-a8aa-2016fa63a6eb"),
                    UserId = user1,
                    TeamId = team2
                }, new UserInTeamEntity
                {
                    ID = new Guid("729ece27-ac92-4d56-a8aa-2016fa63a6eb"),
                    UserId = user1,
                    TeamId = team3
                }, new UserInTeamEntity
                {
                    ID = new Guid("739ece27-ac92-4d56-a8aa-2016fa63a6eb"),
                    UserId = user1,
                    TeamId = team4
                },
                new UserInTeamEntity
                {
                    ID = new Guid("749ece27-ac92-4d56-a8aa-2016fa63a6eb"),
                    UserId = user2,
                    TeamId = team1
                }, new UserInTeamEntity
                {
                    ID = new Guid("759ece27-ac92-4d56-a8aa-2016fa63a6eb"),
                    UserId = user3,
                    TeamId = team1
                }, new UserInTeamEntity
                {
                    ID = new Guid("769ece27-ac92-4d56-a8aa-2016fa63a6eb"),
                    UserId = user4,
                    TeamId = team1
                }, new UserInTeamEntity
                {
                    ID = new Guid("779ece27-ac92-4d56-a8aa-2016fa63a6eb"),
                    UserId = user2,
                    TeamId = team2
                }, new UserInTeamEntity
                {
                    ID = new Guid("789ece27-ac92-4d56-a8aa-2016fa63a6eb"),
                    UserId = user3,
                    TeamId = team2
                },
                new UserInTeamEntity
                {
                    ID = new Guid("799ece27-ac92-4d56-a8aa-2016fa63a6eb"),
                    UserId = user4,
                    TeamId = team3
                });


            Guid post1Team1 = new Guid("ec16e27b-07e2-0f47-b19d-0b362003ca83");
            Guid post2Team1 = new Guid("ec16e27b-17e2-4f47-b19d-0b362003ca83");
            Guid post3Team1 = new Guid("ec16e27b-27e2-4f47-b19d-0b362003ca83");
                                                 
            Guid post1Team2 = new Guid("ec16e27b-07e2-1f47-b19d-0b362003ca83");
            Guid post2Team2 = new Guid("ec16e27b-17e2-2f47-b19d-0b362003ca83");
                                                 
            Guid post1Team3 = new Guid("ec16e27b-07e2-4f47-b19d-0b362003ca83");

            modelBuilder.Entity<PostEntity>().HasData(new PostEntity
            {
                ID = post1Team1, Title = "Mediocrem", MessageText = loremIpsum6,
                AuthorId = user1, TeamId = team1
            }, new PostEntity
            {
                ID = post2Team1,
                Title = "Novum",
                MessageText = loremIpsum1,
                AuthorId = user2,
                TeamId = team1
            }, new PostEntity
            {
                ID = post3Team1,
                Title = "Euismod",
                MessageText = loremIpsum2,
                AuthorId = user3,
                TeamId = team1
            }, new PostEntity
            {
                ID = post1Team2,
                Title = "Splendide",
                MessageText = loremIpsum3,
                AuthorId = user2,
                TeamId = team2
            }, new PostEntity
            {
                ID = post2Team2,
                Title = "Imperdiet",
                MessageText = loremIpsum4,
                AuthorId = user1,
                TeamId = team2
            }, new PostEntity
            {
                ID = post1Team3,
                Title = "Putent",
                MessageText = loremIpsum5,
                AuthorId = user4,
                TeamId = team3
            });

            Guid comment1Post1Team1 = new Guid("ec16e27a-07e2-0f47-b09d-0f362003ca83");
            Guid comment2Post1Team1 = new Guid("ec16e27a-07e2-0f47-b19d-0f362003ca83");
            Guid comment3Post1Team1 = new Guid("ec16e27a-07e2-0f47-b29d-0f362003ca83");
            Guid comment4Post1Team1 = new Guid("ec16e27a-07e2-0f47-b39d-0f362003ca83");
                                                                           
            Guid comment1Post2Team1 = new Guid("ec16e27a-07e2-4f47-b49d-0f362003ca83");
            Guid comment2Post2Team1 = new Guid("ec16e27a-07e2-4f47-b59d-0f362003ca83");
                                                                           
            Guid comment1Post1Team2 = new Guid("ec16e27a-07e2-1f47-b69d-0f362003ca83");
            Guid comment2Post1Team2 = new Guid("ec16e27a-07e2-1f47-b79d-0f362003ca83");
                                                                           
            Guid comment1Post2Team2 = new Guid("ec16e27a-07e2-2f47-b89d-0f362003ca83");

            modelBuilder.Entity<CommentEntity>().HasData(new CommentEntity
            {
                ID = comment1Post1Team1,
                MessageText = loremIpsum2,
                AuthorId = user2
            }, new CommentEntity
            {
                ID = comment2Post1Team1,
                MessageText = loremIpsum1,
                AuthorId = user3
            }, new CommentEntity
            {
                ID = comment3Post1Team1,
                MessageText = loremIpsum3,
                AuthorId = user1
            }, new CommentEntity
            {
                ID = comment4Post1Team1,
                MessageText = loremIpsum4,
                AuthorId = user4
            }, new CommentEntity
            {
                ID = comment1Post2Team1,
                MessageText = loremIpsum5,
                AuthorId = user4
            }, new CommentEntity
            {
                ID = comment2Post2Team1,
                MessageText = loremIpsum6,
                AuthorId = user3
            }, new CommentEntity
            {
                ID = comment1Post1Team2,
                MessageText = loremIpsum7,
                AuthorId = user3
            }, new CommentEntity
            {
                ID = comment2Post1Team2,
                MessageText = loremIpsum8,
                AuthorId = user2
            }, new CommentEntity
            {
                ID = comment1Post2Team2,
                MessageText = loremIpsum9,
                AuthorId = user3
            });
        }
    }
}