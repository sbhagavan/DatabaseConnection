using ServiceStack.OrmLite;
using ServiceStack.OrmLite.SqlServer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2.DatabaseImplementors
{
    public class SqlServerCommentData : ICommentDataHandler
    {
        OrmLiteConnectionFactory dbFactory = new OrmLiteConnectionFactory("Server=(local);Database=3.0;uid=sa;pwd=Md7cX4sT", false, SqlServerOrmLiteDialectProvider.Instance);
        public List<ppComments> GetComments(int nomid)
        {
            IDbConnection dbConn = dbFactory.OpenDbConnection();
            IDbCommand dbCmd = dbConn.CreateCommand();
            var rows = new List<ppComments>() { dbConn.Id<ppComments>(nomid) };
            return rows;
        }

        public int CreateComment(int userid)
        {
            return 0;
        }

    }
}
