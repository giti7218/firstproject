﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Repositories.Entities
{public enum policy {allow,deny}
    class Claim
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public int PermissionId { get; set; }
        public policy Policy { get; set; }
    }

}
