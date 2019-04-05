using System;
using System.Text.RegularExpressions;
using ICS.Project.DAL.Entities.Base;

namespace ICS.Project.DAL.Entities
{
    //TODO: Logika pro kontrolu spravnosti emailove adresy
    public class EmailAdressEntity : EntityBase
    {
        public string Email { get; set; }

    }
}