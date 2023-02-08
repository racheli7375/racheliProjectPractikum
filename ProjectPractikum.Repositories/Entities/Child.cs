using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPractikum.Repositories.Entities
{
    public class Child
    {       
        public String ChildId { get; set; }

        public string FirstName { get; set; }

        public DateTime DateOfBirth { get; set; }
        public string ParentID { get; set; }

    }
}
