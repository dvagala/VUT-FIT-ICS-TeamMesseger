using System.Collections.Generic;
using ICS.Project.DAL.Entities;

internal static class TeamEntityComparer
{
    public static IEqualityComparer<TeamEntity> TeamComparer { get; } = new TeamsComparer();

    private sealed class TeamsComparer : IEqualityComparer<TeamEntity>
    {
        public bool Equals(TeamEntity x, TeamEntity y)
        {
            if (ReferenceEquals(x, y)) return true;

            if (ReferenceEquals(x, null)) return false;

            if (ReferenceEquals(y, null)) return false;

            if (x.GetType() != y.GetType()) return false;

            return string.Equals(x.Name, y.Name) &&
                   string.Equals(x.Description, y.Description) && x.ID.Equals(y.ID);
        }

        public int GetHashCode(TeamEntity obj)
        {
            unchecked
            {
                var hashCode = obj.Description != null ? obj.Description.GetHashCode() : 0;
                hashCode = (hashCode * 397) ^ (obj.Name != null ? obj.Name.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ obj.ID.GetHashCode();
                return hashCode;
            }
        }
    }
}