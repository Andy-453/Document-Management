﻿using System.ComponentModel.DataAnnotations;

namespace Document_Management_Backend.Model
{
    public class User_Type_has_permissions
    {
        public int UserType_Id { get; set; }

        public int Permissions_Id { get; set; }
    }
}