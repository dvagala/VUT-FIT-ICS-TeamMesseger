using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ICS.Project.DAL.Entities.Base;

namespace ICS.Project.DAL.Entities
{
    public class UserEntity : EntityBase
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime LastActivity { get; set; }
        public string Email { get; set; }
        public string Password { get; set; } //has to be kept in secure form

        public ICollection<TeamEntity> Teams { get; set; } = new List<TeamEntity>();

        private sealed class UserEqualityComparer : IEqualityComparer<UserEntity>
        {
            public bool Equals(UserEntity x, UserEntity y)
            {
                if (ReferenceEquals(x, y))
                {
                    return true;
                }

                if (ReferenceEquals(x, null))
                {
                    return false;
                }

                if (ReferenceEquals(y, null))
                {
                    return false;
                }

                if (x.GetType() != y.GetType())
                {
                    return false;
                }

                return x.Teams.SequenceEqual(y.Teams) && x.Teams.Count == y.Teams.Count && string.Equals(x.Name, y.Name) && string.Equals(x.Surname, y.Surname) && string.Equals(x.Email, y.Email) && string.Equals(x.Password, y.Password) && DateTime.Equals(x.LastActivity, y.LastActivity) && x.ID.Equals(y.ID);
            }

            public int GetHashCode(UserEntity obj)
            {
                unchecked
                {
                    var hashCode = (obj.Teams != null ? obj.Teams.GetHashCode() : 0);
                    hashCode = (hashCode * 397) ^ (obj.Name != null ? obj.Name.GetHashCode() : 0);
                    hashCode = (hashCode * 397) ^ (obj.Surname != null ? obj.Surname.GetHashCode() : 0);
                    hashCode = (hashCode * 397) ^ (obj.Email != null ? obj.Email.GetHashCode() : 0);
                    hashCode = (hashCode * 397) ^ (obj.Password != null ? obj.Password.GetHashCode() : 0);
                    hashCode = (hashCode * 397) ^ (obj.LastActivity != null ? obj.LastActivity.GetHashCode() : 0);
                    hashCode = (hashCode * 397) ^ obj.ID.GetHashCode();
                    return hashCode;
                }
            }
        }

        public static IEqualityComparer<UserEntity> UserComparer { get; } = new UserEqualityComparer();
    }

}
