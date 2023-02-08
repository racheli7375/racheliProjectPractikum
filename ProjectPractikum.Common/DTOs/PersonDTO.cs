using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPractikum.Common.DTOs
{
    public enum eGender { male = 1, female = 2 };
    public enum eHMO { klalit = 1, meuchedet = 2, macabi = 4, leumit = 8 };
    public class PersonDTO
    {
        public string PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public eHMO HMO { get; set; }
        public eGender Gender { get; set; }
    }
}
