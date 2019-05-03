using System;
using ICS.Project.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace ICS.Project.DAL
{
    public class MessengerDbContext : DbContext
    {
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


            var user1 = new Guid("ec16e27a-47e2-4f47-b19d-0a362003ca84");
            var user2 = new Guid("ec16e27a-47e2-4f47-b19d-1a362003ca84");
            var user3 = new Guid("ec16e27a-47e2-4f47-b19d-2a362003ca84");
            var user4 = new Guid("ec16e27a-47e2-4f47-b19d-3a362003ca84");

            modelBuilder.Entity<UserEntity>().HasData(new UserEntity
            {
                ID = user1, Name = "Student", Surname = "Roberts",
                Email = "student@fit", PasswordHash = hash,
                Salt = salt,
                IterationCount = 10007,
                IsLoggedIn = false,
                LastLogoutTime = new DateTime(2019, 4, 4, 14, 13, 50)
            }, new UserEntity
            {
                ID = user2,
                Name = "Regan",
                Surname = "Wiggins",
                IsLoggedIn = false,
                LastLogoutTime = new DateTime(2019, 4, 18, 18, 47, 24)
            }, new UserEntity
            {
                ID = user3,
                Name = "Kimberl",
                Surname = "Cohen",
                IsLoggedIn = false,
                LastLogoutTime = new DateTime(2019, 3, 24, 14, 55, 36)
            }, new UserEntity
            {
                ID = user4,
                Name = "Kelley",
                Surname = "Watts",
                IsLoggedIn = false,
                LastLogoutTime = new DateTime(2019, 4, 28, 14, 24, 11)
            });

            var team1 = new Guid("ec16e27a-07e2-4f47-b19d-0a362003ca84");
            var team2 = new Guid("ec16e27a-17e2-4f47-b19d-0a362003ca84");
            var team3 = new Guid("ec16e27a-27e2-4f47-b19d-0a362003ca84");
            var team4 = new Guid("ec16e27a-37e2-4f47-b19d-0a362003ca84");

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
                    ID = new Guid("0c16e27a-07e2-4f47-b19d-0a362003ca84"),
                    UserId = user1,
                    TeamId = team1
                }, new UserInTeamEntity
                {
                    ID = new Guid("1c16e27a-07e2-4f47-b19d-0a362003ca84"),
                    UserId = user1,
                    TeamId = team2
                }, new UserInTeamEntity
                {
                    ID = new Guid("2c16e27a-07e2-4f47-b19d-0a362003ca84"),
                    UserId = user1,
                    TeamId = team3
                }, new UserInTeamEntity
                {
                    ID = new Guid("3c16e27a-07e2-4f47-b19d-0a362003ca84"),
                    UserId = user1,
                    TeamId = team4
                },
                new UserInTeamEntity
                {
                    ID = new Guid("4c16e27a-07e2-4f47-b19d-0a362003ca84"),
                    UserId = user2,
                    TeamId = team1
                }, new UserInTeamEntity
                {
                    ID = new Guid("5c16e27a-07e2-4f47-b19d-0a362003ca84"),
                    UserId = user3,
                    TeamId = team1
                }, new UserInTeamEntity
                {
                    ID = new Guid("6c16e27a-07e2-4f47-b19d-0a362003ca84"),
                    UserId = user4,
                    TeamId = team1
                }, new UserInTeamEntity
                {
                    ID = new Guid("7c16e27a-07e2-4f47-b19d-0a362003ca84"),
                    UserId = user2,
                    TeamId = team2
                }, new UserInTeamEntity
                {
                    ID = new Guid("8c16e27a-07e2-4f47-b19d-0a362003ca84"),
                    UserId = user3,
                    TeamId = team2
                },
                new UserInTeamEntity
                {
                    ID = new Guid("9c16e27a-07e2-4f47-b19d-0a362003ca84"),
                    UserId = user4,
                    TeamId = team3
                });


            var post1Team1 = new Guid("ec16e28b-07e2-0f47-b19d-0b362003ca84");
            var post2Team1 = new Guid("ec16e28b-17e2-4f47-b19d-0b362003ca84");
            var post3Team1 = new Guid("ec16e28b-27e2-4f47-b19d-0b362003ca84");

            var post1Team2 = new Guid("ec16e28b-07e2-1f47-b19d-0b362003ca84");
            var post2Team2 = new Guid("ec16e28b-17e2-2f47-b19d-0b362003ca84");

            var post1Team3 = new Guid("ec16e28b-07e2-4f47-b19d-0b362003ca84");

            modelBuilder.Entity<PostEntity>().HasData(new PostEntity
            {
                ID = post1Team1, Title = "Mediocrem", MessageText = loremIpsum6,
                AuthorId = user1, TeamId = team1,
                PublishDate = new DateTime(2019, 2, 1, 3, 31, 12)
            }, new PostEntity
            {
                ID = post2Team1,
                Title = "Novum",
                MessageText = loremIpsum1,
                AuthorId = user2,
                TeamId = team1,
                PublishDate = new DateTime(2019, 3, 1, 1, 8, 54)
            }, new PostEntity
            {
                ID = post3Team1,
                Title = "Euismod",
                MessageText = loremIpsum2,
                AuthorId = user3,
                TeamId = team1,
                PublishDate = new DateTime(2019, 5, 14, 18, 21, 7)
            }, new PostEntity
            {
                ID = post1Team2,
                Title = "Splendide",
                MessageText = loremIpsum3,
                AuthorId = user2,
                TeamId = team2,
                PublishDate = new DateTime(2019, 1, 1, 8, 36, 50)
            }, new PostEntity
            {
                ID = post2Team2,
                Title = "Imperdiet",
                MessageText = loremIpsum4,
                AuthorId = user1,
                TeamId = team2,
                PublishDate = new DateTime(2019, 2, 1, 12, 13, 50)
            }, new PostEntity
            {
                ID = post1Team3,
                Title = "Putent",
                MessageText = loremIpsum5,
                AuthorId = user4,
                TeamId = team3,
                PublishDate = new DateTime(2019, 4, 1, 7, 13, 50)
            });

            var comment1Post1Team1 = new Guid("dc16e27a-07e2-0f47-b09d-0f362003ca84");
            var comment2Post1Team1 = new Guid("dc16e27a-07e2-0f47-b19d-0f362003ca84");
            var comment3Post1Team1 = new Guid("dc16e27a-07e2-0f47-b29d-0f362003ca84");
            var comment4Post1Team1 = new Guid("dc16e27a-07e2-0f47-b39d-0f362003ca84");

            var comment1Post2Team1 = new Guid("dc16e27a-07e2-4f47-b49d-0f362003ca84");
            var comment2Post2Team1 = new Guid("dc16e27a-07e2-4f47-b59d-0f362003ca84");

            var comment1Post1Team2 = new Guid("dc16e27a-07e2-1f47-b69d-0f362003ca84");
            var comment2Post1Team2 = new Guid("dc16e27a-07e2-1f47-b79d-0f362003ca84");

            var comment1Post2Team2 = new Guid("dc16e27a-07e2-2f47-b89d-0f362003ca84");

            modelBuilder.Entity<CommentEntity>().HasData(new CommentEntity
            {
                ID = comment1Post1Team1,
                MessageText = loremIpsum2,
                AuthorId = user2,
                PostId = post1Team1,
                PublishDate = new DateTime(2019, 2, 1, 5, 12, 4)
            }, new CommentEntity
            {
                ID = comment2Post1Team1,
                MessageText = loremIpsum1,
                AuthorId = user3,
                PostId = post1Team1,
                PublishDate = new DateTime(2019, 2, 3, 4, 17, 40)
            }, new CommentEntity
            {
                ID = comment3Post1Team1,
                MessageText = loremIpsum3,
                AuthorId = user1,
                PostId = post1Team1,
                PublishDate = new DateTime(2019, 3, 10, 11, 19, 31)
            }, new CommentEntity
            {
                ID = comment4Post1Team1,
                MessageText = loremIpsum4,
                AuthorId = user4,
                PostId = post1Team1,
                PublishDate = new DateTime(2019, 3, 10, 11, 20, 39)
            }, new CommentEntity
            {
                ID = comment1Post2Team1,
                MessageText = loremIpsum5,
                AuthorId = user4,
                PostId = post2Team1,
                PublishDate = new DateTime(2019, 3, 1, 1, 14, 2)
            }, new CommentEntity
            {
                ID = comment2Post2Team1,
                MessageText = loremIpsum6,
                AuthorId = user3,
                PostId = post2Team1,
                PublishDate = new DateTime(2019, 3, 1, 2, 4, 20)
            }, new CommentEntity
            {
                ID = comment1Post1Team2,
                MessageText = loremIpsum7,
                AuthorId = user3,
                PostId = post1Team2,
                PublishDate = new DateTime(2019, 1, 1, 7, 14, 50)
            }, new CommentEntity
            {
                ID = comment2Post1Team2,
                MessageText = loremIpsum8,
                AuthorId = user2,
                PostId = post1Team2,
                PublishDate = new DateTime(2019, 1, 1, 7, 15, 50)
            }, new CommentEntity
            {
                ID = comment1Post2Team2,
                MessageText = loremIpsum9,
                AuthorId = user3,
                PostId = post2Team2,
                PublishDate = new DateTime(2019, 2, 12, 7, 13, 52)
            });
        }
    }
}