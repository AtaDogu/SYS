using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class EmployeeManager:IEmployeeService
    {
        private IEmployeeDal _employeeDal;

        public EmployeeManager(IEmployeeDal employeeDal)
        {
            _employeeDal = employeeDal;
        }

        public IDataResult<List<Employee>> GetAll()
        {
            return new SuccessDataResult<List<Employee>>(_employeeDal.GetAll());
        }

        public IDataResult<Employee> GetById(int id)
        {
            return new SuccessDataResult<Employee>(_employeeDal.Get(e=>e.EmployeeId==id));
        }

        public IDataResult<Employee> GetByName(string name)
        {
            return new SuccessDataResult<Employee>(_employeeDal.Get(e => e.FirstName == name));
        }

        public IResult Add(Employee employee)
        {
            _employeeDal.Add(employee);
            return new SuccessResult();
        }

        public IResult Update(Employee employee)
        {
            _employeeDal.Update(employee);
            return new SuccessResult();
        }

        public IResult Delete(Employee employee)
        {
            _employeeDal.Delete(employee);
            return new SuccessResult();
        }
    }
}
