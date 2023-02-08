using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectPractikum.Common.DTOs;
using ProjectPractikum.Services.Interfaces;

namespace ProjectPractikum.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChildController : ControllerBase
    {
        private readonly IChildService _childService;
        public ChildController(IChildService roleService)
        {
            _childService = roleService;
        }
        [HttpGet]
        public async Task<List<ChildDTO>> Get()
        {
            return await _childService.GetAllAsync();
        }
        [HttpGet("{id}")]
        public async Task<ChildDTO> Get(string id)
        {
            return await _childService.GetByIdAsync(id);
        }
        [HttpDelete("{id}")]
        public async Task Delete(string id)
        {
            await _childService.DeleteAsync(id);
        }
        [HttpPut]
        public async Task<ChildDTO> Update([FromBody] ChildDTO model)
        {
            return await _childService.UpdateAsync(new ChildDTO()
            { ChildId = model.ChildId, FirstName = model.FirstName, DateOfBirth = model.DateOfBirth, ParentID = model.ParentID });
        }
        [HttpPost]
        public async Task<ChildDTO> Post([FromBody] ChildDTO model)
        {
            ChildDTO r = await _childService.AddAsync(new ChildDTO()
            { ChildId = model.ChildId, FirstName = model.FirstName, DateOfBirth = model.DateOfBirth, ParentID = model.ParentID });
            return r;
        }
    }
}
