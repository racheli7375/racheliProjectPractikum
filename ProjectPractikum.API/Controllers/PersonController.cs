using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectPractikum.Common.DTOs;
using ProjectPractikum.Services.Interfaces;

namespace ProjectPractikum.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;
        public PersonController(IPersonService personService)
        {

            _personService = personService;
        }
        [HttpGet]
        public async Task<List<PersonDTO>> Get()
        {
            return await _personService.GetAllAsync();
        }
        [HttpGet("{id}")]
        public async Task<PersonDTO> Get(string id)
        {
            return await _personService.GetByIdAsync(id);
        }
        [HttpDelete("{id}")]
        public async Task Delete(string id)
        {
            await _personService.DeleteAsync(id);
        }
        [HttpPut]
        public async Task<PersonDTO> Update([FromBody] PersonDTO model)
        {
            return await _personService.UpdateAsync(new PersonDTO() 
            {PersonId=model.PersonId, FirstName = model.FirstName,LastName=model.LastName,HMO=model.HMO,Gender=model.Gender,DateOfBirth=model.DateOfBirth });
        }
        [HttpPost]
        public async Task<PersonDTO> Post([FromBody] PersonDTO model)
        {
            PersonDTO p = await _personService.AddAsync(new PersonDTO()
            {PersonId=model.PersonId, FirstName = model.FirstName, LastName = model.LastName, HMO = model.HMO, Gender = model.Gender, DateOfBirth = model.DateOfBirth  });
            return p;
        }
    }
}
