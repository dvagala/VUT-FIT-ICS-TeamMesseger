using System;
using System.Collections.Generic;
using System.Linq;
using ICS.Project.DAL.Entities;

static internal class TeamEntityComparer
{
    private sealed class NameDescriptionIdEqualityComparer : IEqualityComparer<TeamEntity>
    {
        public bool Equals(TeamEntity x, TeamEntity y)
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

            return x.Posts.SequenceEqual(y.Posts) && x.Posts.Count == y.Posts.Count && String.Equals(x.Name, y.Name) && String.Equals(x.Description, y.Description) && x.ID.Equals(y.ID);
        }

        public int GetHashCode(TeamEntity obj)
        {
            unchecked
            {
                var hashCode = (obj.Posts != null ? obj.Posts.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (obj.Name != null ? obj.Name.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (obj.Description != null ? obj.Description.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ obj.ID.GetHashCode();
                return hashCode;
            }
        }
    }

    public static IEqualityComparer<TeamEntity> NameDescriptionIdComparer { get; } = new NameDescriptionIdEqualityComparer();
}