using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    public interface IUserDataHandler
    {
        User GetUser(int userId);
        int CreateUser(int portalid);
        
    }
}
