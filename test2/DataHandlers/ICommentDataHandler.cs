using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    public interface ICommentDataHandler
    {
        List<ppComments> GetComments(int nomid);
        int CreateComment(int userid);
    }
}
