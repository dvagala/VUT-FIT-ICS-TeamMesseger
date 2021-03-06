﻿using System;
using ICS.Project.DAL.Entities.Base;

namespace ICS.Project.DAL.Entities
{
    public class UserEntity : EntityBase
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime LastLogoutTime { get; set; }
        public bool IsLoggedIn { get; set; }
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] Salt { get; set; }
        public int IterationCount { get; set; }
    }
}