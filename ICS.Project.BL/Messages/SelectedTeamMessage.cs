using System;
using System.Collections.Generic;
using System.Text;

namespace ICS.Project.BL.Messages
{
    public class SelectedTeamMessage : IMessage
    {
        public Guid Id { get; set; }
    }
}
