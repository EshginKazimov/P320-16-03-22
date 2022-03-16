using AutoMapper;
using P320.DomainModels.DTOs;
using P320.DomainModels.Entities;
using P320.Repository.DataContext;
using P320.Repository.Repository;
using P320.Services.Services.Contracts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace P320.Services.Services
{
    public class StudentService : EfCoreRepository<Student>, IStudentService
    {
        private readonly IMapper _mapper;

        public StudentService(AppDbContext dbContext, IMapper mapper) : base(dbContext)
        {
            _mapper = mapper;
        }

        public async Task<IList<StudentDto>> GetAllStudentsAsync()
        {
            var students = await GetAllAsync();

            return _mapper.Map<List<StudentDto>>(students);
        }

        public object GetTest()
        {
            return "Test";
        }
    }
}
