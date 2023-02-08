using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPractikum.Repositories.Entities
{
    public enum EGender {male=1,female=2 };
    public enum EHMO { klalit=1, meuchedet=2,macabi=4,leumit=8 };

    public class Person
    {
        public string PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public EGender HMO  { get; set; }
        public EHMO Gender  { get; set; }
       

    }
}
