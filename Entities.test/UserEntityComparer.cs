using System.Collections.Generic;
using ICS.Project.DAL.Entities;

internal static class UserEntityComparer
{
    public static IEqualityComparer<UserEntity> UserComparer { get; } = new UsersComparer();

    private sealed class UsersComparer : IEqualityComparer<UserEntity>
    {
        public bool Equals(UserEntity x, UserEntity y)
        {
            if (ReferenceEquals(x, y)) return true;

            if (ReferenceEquals(x, null)) return false;

            if (ReferenceEquals(y, null)) return false;

            if (x.GetType() != y.GetType()) return false;

            return string.Equals(x.Name, y.Name) && x.ID.Equals(y.ID) &&
                   string.Equals(x.Surname, y.Surname) && string.Equals(x.Email, y.Email) && Equals(
                       x.LastLogoutTime.ToString("MM/dd/yyyy HH:mm:ss"),
                       y.LastLogoutTime.ToString("MM/dd/yyyy HH:mm:ss"));
        }

        public int GetHashCode(UserEntity obj)
        {
            unchecked
            {
                var hashCode = obj.Name != null ? obj.Name.GetHashCode() : 0;
                hashCode = (hashCode * 397) ^ (obj.Surname != null ? obj.Surname.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (obj.Email != null ? obj.Email.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (obj.PasswordHash != null ? obj.PasswordHash.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (obj.LastLogoutTime != null ? obj.LastLogoutTime.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ obj.ID.GetHashCode();
                return hashCode;
            }
        }
    }
}