using AutoMapper;
using CleanArchitecture.Application.Features.Departments;
using CleanArchitecture.Application.Features.Departments.Command.CreateDepartment;
using CleanArchitecture.Application.Features.Departments.Command.UpdateDepartment;
using CleanArchitecture.Application.Features.Departments.Queries.GetDepartmentList;
using CleanArchitecture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Profiles
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Department, DepartmentListVm>().ReverseMap();
            CreateMap<Department, CreateDepartmentCommand>().ReverseMap();
            CreateMap<Department, CreateDepartmentDto>();

            CreateMap<UpdateDepartmentCommand, Department>();
        }
    }
}
