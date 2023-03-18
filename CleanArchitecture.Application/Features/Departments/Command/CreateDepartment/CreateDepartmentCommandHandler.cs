using AutoMapper;
using CleanArchitecture.Application.Contracts.Persistance;
using CleanArchitecture.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Departments.Command.CreateDepartment
{
    public class CreateDepartmentCommandHandler : IRequestHandler<CreateDepartmentCommand, CreateDepartmentResponse>
    {
        private readonly IDepartmentRepository _departmentRepository;
        private readonly IMapper _mapper;

        public CreateDepartmentCommandHandler(IDepartmentRepository departmentRepository, IMapper mapper)
        {
            _departmentRepository = departmentRepository;
            _mapper = mapper;
        }
        public async Task<CreateDepartmentResponse> Handle(CreateDepartmentCommand request, CancellationToken cancellationToken)
        {
            var createDepartmentResponse = new CreateDepartmentResponse();


            var validationResult = await (new CreateDepartmentCommandValidator()).ValidateAsync(request);

            if (validationResult.IsValid && validationResult.Errors.Count > 0)
            {
                createDepartmentResponse.Success = false;
                createDepartmentResponse.Errors = new List<string>();
                foreach (var item in validationResult.Errors)
                {
                    createDepartmentResponse.Errors.Add(item.ErrorMessage);
                }

            }
            else
            {
                var @department = _mapper.Map<Department>(request);

                @department = await _departmentRepository.AddAsync(@department);

                createDepartmentResponse.Department = _mapper.Map<CreateDepartmentDto>(@department);
            }

            return createDepartmentResponse;
        }

    }
}
