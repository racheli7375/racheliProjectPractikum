using AutoMapper;
using ProjectPractikum.Common.DTOs;
using ProjectPractikum.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPractikum.Services
{
    public class Mapping:Profile
    {
        public Mapping()
        {
            CreateMap<Person, PersonDTO>().ReverseMap();
             CreateMap<Child, ChildDTO>().ReverseMap();
             
        }
    }
}
