using ProjectPractikum.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPractikum.Common.DTOs
{
    public class ChildDTO
    {
        public String ChildId { get; set; }

        public string FirstName { get; set; }

        public DateTime DateOfBirth { get; set; }
        public string ParentID { get; set; }
    }
}
