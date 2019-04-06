using System;
using System.Collections.Generic;
using System.Text;
using ICS.Project.DAL.Entities;
using ICS.Project.BL.Models;

namespace ICS.Project.BL.Mapper
{
    interface IMapper
    {
        PostEntity MapPostModelToEntity(PostModel model);
        PostModel MapPostModelFromEntity(PostEntity post);
    }
}
