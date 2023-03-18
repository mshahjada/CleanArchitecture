using AutoMapper;
using CleanArchitecture.Application.Contracts.Persistance;
using CleanArchitecture.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Departments.Command.UpdateDepartment
{
    public class UpdateDepartmentCommandHandler:IRequestHandler<UpdateDepartmentCommand>
    {
        public readonly IDepartmentRepository _departmentRepository;
        private readonly IMapper _mapper;
        public UpdateDepartmentCommandHandler(
            IDepartmentRepository departmentRepository,
            IMapper mapper
            )
        {
            _departmentRepository = departmentRepository;
            _mapper = mapper;
        }

        public async Task Handle(UpdateDepartmentCommand request, CancellationToken cancellationToken)
        {
            var departmentToUpdate = await _departmentRepository.GetByIdAsync(request.Id);

            _mapper.Map(request, departmentToUpdate, typeof(UpdateDepartmentCommand), typeof(Department));

            await _departmentRepository.UpdateAsync(departmentToUpdate);

        }
    }
}
