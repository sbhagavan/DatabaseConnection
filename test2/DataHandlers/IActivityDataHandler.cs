using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    public interface IActivityDataHandler
    {
        int CreateActivityItem();
        ppNominationActivitiesB GetActivity(int activityId);
        List<ppNominationActivitiesB> GetAllActivities(int portalId);
    }
}
