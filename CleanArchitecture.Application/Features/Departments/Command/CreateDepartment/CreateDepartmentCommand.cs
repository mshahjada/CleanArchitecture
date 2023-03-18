using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Departments.Command.CreateDepartment
{
    public class CreateDepartmentCommand: IRequest<CreateDepartmentResponse>
    {
        public string Name { get; set; }
        public string Code { get; set; }
    }
}
