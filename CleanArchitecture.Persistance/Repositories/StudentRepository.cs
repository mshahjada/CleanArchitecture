using CleanArchitecture.Application.Contracts.Persistance;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Persistance.Repositories
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public StudentRepository(ApplicationDBContext dBContext) : base(dBContext)
        {

        }
    }
}
