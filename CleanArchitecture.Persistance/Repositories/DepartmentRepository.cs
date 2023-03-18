using CleanArchitecture.Application.Contracts.Persistance;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Persistance.Repositories
{
    public class DepartmentRepository: Repository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(ApplicationDBContext dBContext): base(dBContext)
        {

        }
    }
}
