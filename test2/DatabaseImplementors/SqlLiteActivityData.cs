using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    public class SqlLiteActivityData : IActivityDataHandler
    {
        public int CreateActivityItem()
        {
            return 0;
        }

        public ppNominationActivitiesB GetActivity(int activityId)
        {
            return null;
        }

        public List<ppNominationActivitiesB> GetAllActivities(int portalId)
        {
            return null;
        }
    }
}
