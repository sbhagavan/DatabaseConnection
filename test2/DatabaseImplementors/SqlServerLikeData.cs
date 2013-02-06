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
    public class SqlServerLikeData : ILikeDataHandler
    {
        OrmLiteConnectionFactory dbFactory = new OrmLiteConnectionFactory("Server=(local);Database=3.0;uid=sa;pwd=Md7cX4sT", false, SqlServerOrmLiteDialectProvider.Instance);
        public List<ppLikes> GetLike(int nomid)
        {
            IDbConnection dbConn = dbFactory.OpenDbConnection();
            IDbCommand dbCmd = dbConn.CreateCommand();
            var likes = dbCmd.Select<ppLikes>("select * from ppLikes where nom_nid={0}", nomid);
            return likes;
        }

        public int CreateLike(int nomid)
        {
            return 0;
        }
    }
}
