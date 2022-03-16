using P320.DomainModels.DTOs;
using P320.DomainModels.Entities;
using P320.Repository.Repository.Contracts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace P320.Services.Services.Contracts
{
    public interface IStudentService : IRepository<Student>
    {
        object GetTest();

        Task<IList<StudentDto>> GetAllStudentsAsync();
    }
}
