using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Departments.Queries.GetDepartmentList
{
    public class GetDepartmentListQuery:IRequest<List<DepartmentListVm>>
    {

    }
}
