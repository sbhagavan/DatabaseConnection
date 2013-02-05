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
    public class SqlServerActivityData : IActivityDataHandler
    {
        OrmLiteConnectionFactory dbFactory = new OrmLiteConnectionFactory("Server=(local);Database=3.0;uid=sa;pwd=pp@dm1n", false, SqlServerOrmLiteDialectProvider.Instance);
        public int CreateActivityItem()
        {
            return 0;
        }

        public ppNominationActivitiesB GetActivity(int activityId)
        {
            IDbConnection dbConn = dbFactory.OpenDbConnection();
            IDbCommand dbCmd = dbConn.CreateCommand();
            var activity = dbCmd.Select<ppNominationActivitiesB>("select * from ppNominationActivitiesB where nom_nid = {0}", activityId).FirstOrDefault();
            return activity;
        }

        public List<ppNominationActivitiesB> GetAllActivities(int portalId)
        {
            IDbConnection dbConn = dbFactory.OpenDbConnection();
            IDbCommand dbCmd = dbConn.CreateCommand();
            var activities = dbCmd.Select<ppNominationActivitiesB>("select * from ppNominationActivitiesB where portalid ={0}", portalId);
            return activities;
        }
    }
}
