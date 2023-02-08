using AutoMapper;
using ProjectPractikum.Common.DTOs;
using ProjectPractikum.Repositories.Entities;
using ProjectPractikum.Repositories.Interfaces;
using ProjectPractikum.Repositories.Repositories;
using ProjectPractikum.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPractikum.Services.Services
{
    public class ChildService:IChildService
    {
        private readonly IChildRepository _childRepository;
        private readonly IMapper _mapper;

        public ChildService(IChildRepository claimRepository, IMapper mapper)
        {
            _childRepository = claimRepository;
            _mapper = mapper;
        }

        public async Task<ChildDTO> AddAsync(ChildDTO c)
        {
            
            return _mapper.Map<ChildDTO>(await _childRepository.AddAsync(_mapper.Map<Child>(c)));
        }

        public async Task DeleteAsync(string id)
        {
            await _childRepository.DeleteAsync(id);
        }

        public async Task<List<ChildDTO>> GetAllAsync()
        {
            return _mapper.Map<List<ChildDTO>>(await _childRepository.GetAllAsync());
        }

        public async Task<ChildDTO> GetByIdAsync(string id)
        {
            return _mapper.Map<ChildDTO>(await _childRepository.GetByIdAsync(id));
        }

        public async Task<ChildDTO> UpdateAsync(ChildDTO child)
        {
           
            return _mapper.Map<ChildDTO>(await _childRepository.UpdateAsync(_mapper.Map<Child>(child)));

        }

    }
}
