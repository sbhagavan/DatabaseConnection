using ServiceStack.OrmLite;
using ServiceStack.OrmLite.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    public class SqlLiteCommentData : ICommentDataHandler
    {
        OrmLiteConnectionFactory dbFactory = new OrmLiteConnectionFactory(":memory:", false, SqliteOrmLiteDialectProvider.Instance);
        public List<ppComments> GetComments(int nomid)
        {
            return null;
        }

        public int CreateComment(int nomid)
        {
            return 0;
        }

       
    }
}
