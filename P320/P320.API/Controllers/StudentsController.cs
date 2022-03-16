using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using P320.DomainModels.DTOs;
using P320.DomainModels.Entities;
using P320.Repository.DataContext;
using P320.Repository.Repository.Contracts;
using P320.Services.Services.Contracts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace P320.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IRepository<Student> _repository;
        private readonly IMapper _mapper;
        private readonly IStudentService _service;

        public StudentsController(IMapper mapper, IRepository<Student> repository, IStudentService service)
        {
            _mapper = mapper;
            _repository = repository;
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _service.GetAllStudentsAsync());
        }

        [HttpGet("{id?}")]
        public async Task<IActionResult> Get([FromRoute] int? id)
        {
            if (id == null)
                return NotFound();

            var student = await _repository.GetAsync(id.Value);
            if (student == null)
                return NotFound();

            return Ok(_mapper.Map<StudentDto>(student));
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] StudentDto studentDto)
        {
            var student = _mapper.Map<Student>(studentDto);

            await _repository.AddAsync(student);

            return Ok(student.Id);
        }

        [HttpPut("{id?}")]
        public async Task<IActionResult> Put([FromRoute] int? id, [FromBody] StudentDto studentDto)
        {
            if (id == null)
                return NotFound();

            if (id != studentDto.Id)
                return BadRequest();

            var existStudent = await _repository.GetAsync(id.Value);
            if (existStudent == null)
                return NotFound();

            var student = _mapper.Map<Student>(studentDto);

            await _repository.UpdateAsync(student);

            return Ok();
        }

        [HttpDelete("{id?}")]
        public async Task<IActionResult> Delete([FromRoute] int? id)
        {
            if (id == null)
                return NotFound();

            var student = await _repository.GetAsync(id.Value);
            if (student == null)
                return NotFound();

            await _repository.DeleteAsync(student);

            return NoContent();
        }
    }
}
