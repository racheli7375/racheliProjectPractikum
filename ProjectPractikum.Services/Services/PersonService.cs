using AutoMapper;
using ProjectPractikum.Common.DTOs;
using ProjectPractikum.Repositories.Entities;
using ProjectPractikum.Repositories.Interfaces;
using ProjectPractikum.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjectPractikum.Services.Services
{
    public class PersonService: IPersonService
    {
        private readonly IPersonRepository _personRepository;
        private readonly IMapper _mapper;

        public PersonService(IPersonRepository personRepository, IMapper mapper)
        {
            _personRepository = personRepository;
            _mapper = mapper;
        }

        public async Task<PersonDTO> AddAsync(PersonDTO person)
        {
         

            return _mapper.Map<PersonDTO>(await _personRepository.AddAsync(_mapper.Map<Person>(person)));
        }

        public async Task DeleteAsync(string id)
        {
            await _personRepository.DeleteAsync(id);
        }

        public async Task<List<PersonDTO>> GetAllAsync()
        {
            return _mapper.Map<List<PersonDTO>>(await _personRepository.GetAllAsync());
        }

        public async Task<PersonDTO> GetByIdAsync(string id)
        {
            return _mapper.Map<PersonDTO>(await _personRepository.GetByIdAsync(id));
        }

        public async Task<PersonDTO> UpdateAsync(PersonDTO person)
        {
            return _mapper.Map<PersonDTO>(await _personRepository.UpdateAsync(_mapper.Map<Person>(person)));

        }

    }
}
