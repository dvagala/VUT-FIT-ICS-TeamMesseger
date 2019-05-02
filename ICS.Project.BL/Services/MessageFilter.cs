using System;
using System.Collections.Generic;
using System.Text;
using ICS.Project.BL.Models;

namespace ICS.Project.BL.Services
{
    public class MessageFilter
    {
        public IList<PostModel> GetPostsThatContains(IList<PostModel> unfilteredPosts, string searchedText)
        {
            IList<PostModel> filteredPosts = unfilteredPosts;

            foreach (var post in unfilteredPosts)
            {
                foreach (var comment in post.Comments)
                {
                    
                }
            }

            return filteredPosts;
        }
    }
}
