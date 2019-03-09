using System;
using System.Text.RegularExpressions;

namespace ICS.Project.DAL.Entities
{
    public class RegexUtilities
    {
        public bool IsValidEmail(string EmailAddress)
        {
            //TODO
            if (EmailAddress == "regex_match")
            {
                return true;
            }
            else
            { 
                return false;
            }
        }
    }
}
