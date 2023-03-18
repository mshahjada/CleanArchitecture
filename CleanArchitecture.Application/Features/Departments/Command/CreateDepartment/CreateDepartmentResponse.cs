using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Departments.Command.CreateDepartment
{
    public class CreateDepartmentResponse: Responses.BaseResponse
    {
        public CreateDepartmentResponse():base(){}

        public CreateDepartmentDto Department { get; set; }
    }
}
