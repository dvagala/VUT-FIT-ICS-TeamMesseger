using System;
using System.Collections.Generic;
using System.Linq;
using ICS.Project.DAL.Entities;

static internal class PostEntityComparer
{
    private sealed class TitleCommentsIdEqualityComparer : IEqualityComparer<PostEntity>
    {
        public bool Equals(PostEntity x, PostEntity y)
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

            return x.Comments.SequenceEqual(y.Comments) && x.Comments.Count == y.Comments.Count && String.Equals(x.Title, y.Title) && x.ID.Equals(y.ID);
        }

        public int GetHashCode(PostEntity obj)
        {
            unchecked
            {
                var hashCode = (obj.Comments != null ? obj.Comments.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (obj.Title != null ? obj.Title.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ obj.ID.GetHashCode();
                return hashCode;
            }
        }
    }

    public static IEqualityComparer<PostEntity> TitleCommentsIdComparer { get; } = new TitleCommentsIdEqualityComparer();
}