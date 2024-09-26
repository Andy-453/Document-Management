﻿using System.ComponentModel.DataAnnotations;

namespace DocumentManagementBackend.Model
{
    public class Family_Group
    {
        public int Users_UserType_Id { get; set; }

        public int Documents_Document_Id { get; set; }

        public required string Members { get; set; }
    }
}
