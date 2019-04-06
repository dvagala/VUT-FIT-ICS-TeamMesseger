using System;
using System.Collections.Generic;
using System.Text;
using ICS.Project.BL.Models;
using ICS.Project.DAL.Entities;

namespace ICS.Project.BL.Mapper
{
    public class Mapper : IMapper
    {
        public PostEntity MapPostModelToEntity(PostModel model)
        {
            return new PostEntity
            {
                ID = model.ID,
                Title = model.Title
            };
        }

        public PostModel MapPostModelFromEntity(PostEntity post)
        {
            return new PostModel
            {
                ID = post.ID,
                Title = post.Title
            };
        }
    }
}
