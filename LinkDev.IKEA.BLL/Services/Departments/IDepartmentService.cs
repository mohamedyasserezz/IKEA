﻿using LinkDev.IKEA.BLL.Models.Departments;
using LinkDev.IKEA.DAL.Entities.Department;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkDev.IKEA.BLL.Services.Departments
{
    public interface IDepartmentService
    {
        DepartmentDetailsDto? GetDepartmentsById(int id);
        IEnumerable<DepartmentDto> GetAllDepartments();
        int CreateDepartment(CreatedDepartmentDto departmentDto);
        int UpdateDepartment(UpdatedDepartmentDto departmentDto);
        bool DeleteDepartment(int id);
    }
}
