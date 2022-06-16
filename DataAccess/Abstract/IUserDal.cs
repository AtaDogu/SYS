using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Conrete;
using Core.DataAccess;

namespace DataAccess.Abstract
{
    public interface IUserDal:IEntityRepository<User>
    {
        List<OperationClaim> GetClaims(User user);
    }
}
