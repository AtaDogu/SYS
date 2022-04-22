using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IEmployeeService
    {
        IDataResult<List<Employee>> GetAll();
        IDataResult<Employee> GetById(int id);
        IDataResult<Employee> GetByName(string name);
        IResult Add(Employee employee);
        IResult Update(Employee employee);
        IResult Delete(Employee employee);
    }
}
