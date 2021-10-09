using System.Collections.Generic;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace p20_blazorcrud.Data
{
    public class EmployeeService
    {
        #region Property
        private readonly AppDBContext _appDBContext;
        #endregion

        #region Constructor
        public EmployeeService(AppDBContext appDBContext) => _appDBContext = appDBContext;
        #endregion

        #region Obtiener todos los empleados
        public List<Employee> GetAllEmployees() => _appDBContext.Employees.ToList();
        #endregion

        #region Obtener un solo empleado
        public Employee GetEmployee(int Id)
        {
            Employee employee = _appDBContext.Employees.FirstOrDefault(c => c.Id.Equals(Id));
            return employee;
        }
        #endregion

        #region Insertar empleado
        public bool InsertEmployee(Employee employee)
        {
            _appDBContext.Employees.Add(employee);
            _appDBContext.SaveChanges();
            return true;
        }
        #endregion

        #region Actualizar un empleado
        public bool UpdateEmployee(Employee employee)
        {
            _appDBContext.Employees.Update(employee);
            _appDBContext.SaveChanges();
            return true;
        }
        #endregion

        #region Borrar un empleado
        public bool DeleteEmployee(Employee employee)
        {
            _appDBContext.Remove(employee);
            _appDBContext.SaveChanges();
            return true;
        }
        #endregion
    }
}