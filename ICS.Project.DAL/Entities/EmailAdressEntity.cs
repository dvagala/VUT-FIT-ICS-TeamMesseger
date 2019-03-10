using System;
using System.Text.RegularExpressions;

namespace ICS.Project.DAL.Entities
{
    public class EmailAdressEntity
    {
        public string Email { get; set; }

        public EmailAdressEntity (string EmailInput)
        {
            if (string.IsNullOrEmpty(EmailInput))
                throw new ArgumentException("Email adress cannot be empty.");

            RegexUtilities Regex = new RegexUtilities();
            if (Regex.IsValidEmail(EmailInput) == true)
            {
                Email = EmailInput;
            }
            else
            {
                throw new ArgumentException("Wrong email adress format.");
            }
        }
    }
}