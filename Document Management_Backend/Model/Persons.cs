﻿using System.ComponentModel.DataAnnotations;

namespace DocumentManagementBackend.Model
{
    public class Persons
    {
        [Key]
        public int Id { get; set; }

        public required string Name { get; set; }

        public required string DateBirth { get; set; }

        public required int Phone { get; set; }

        public required DateTime DateRegistration { get; set; }

        public required string ProfilePicture { get; set; }

        public required bool AccountStatus { get; set; }

        public required DateTime LastLogin { get; set; }

        public required string TokenRecovery { get; set; }

        public virtual required User User { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}