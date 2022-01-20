﻿using blazorApp.Services;
using Microsoft.AspNetCore.Components;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blazorApp.Pages
{
    public class EditEmployeeBase : ComponentBase
    {
        [Inject]
        public IEmployeeService EmployeeService { get; set; }
        public Employee Employee { get; set; } = new Employee();
        [Inject]
        public IDepartmentService DepartmentService { get; set; }
        public List<Department> Departments { get; set; } = new List<Department>();

        public string DepartmentId { get; set; }
        [Parameter]
        public string Id { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        protected async override Task OnInitializedAsync()
        {
            Employee = await EmployeeService.GetEmployee(int.Parse(Id));
            Departments = (await DepartmentService.GetDepartments()).ToList();
            DepartmentId = Employee.DepartmentId.ToString();
        }
        protected async Task HandleValidSubmit()
        {
            Employee.DepartmentId = int.Parse(DepartmentId);
            var result = await EmployeeService.UpdateEmployee(Employee);
            if (result != null)
            {
                NavigationManager.NavigateTo("/EmployeeList");
            }
        }
        /*protected async Task Delete_Click()
        {
            await EmployeeService.DeleteEmployee(Employee.EmployeeId);
            NavigationManager.NavigateTo("/EmployeeList");
        }*/

        /*protected async override Task OnInitializedAsync()
        {
            Employee = await EmployeeService.GetEmployee(int.Parse(Id));
        }*/
    }
}
