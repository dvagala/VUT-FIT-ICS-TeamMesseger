using System.Collections.Generic;
using ICS.Project.DAL.Entities;

internal static class PostEntityComparer
{
    public static IEqualityComparer<PostEntity> PostComparer { get; } = new PostsComparer();

    private sealed class PostsComparer : IEqualityComparer<PostEntity>
    {
        public bool Equals(PostEntity x, PostEntity y)
        {
            if (ReferenceEquals(x, y)) return true;

            if (ReferenceEquals(x, null)) return false;

            if (ReferenceEquals(y, null)) return false;

            if (x.GetType() != y.GetType()) return false;

            return string.Equals(x.MessageText, y.MessageText) && Equals(x.PublishDate, y.PublishDate) &&
                   string.Equals(x.Title, y.Title) && x.ID.Equals(y.ID) && x.AuthorId.Equals(y.AuthorId);
        }

        public int GetHashCode(PostEntity obj)
        {
            unchecked
            {
                var hashCode = obj.Title != null ? obj.Title.GetHashCode() : 0;
                hashCode = (hashCode * 397) ^ obj.ID.GetHashCode();
                return hashCode;
            }
        }
    }
}