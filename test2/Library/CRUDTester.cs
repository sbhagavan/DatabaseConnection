using ServiceStack.OrmLite.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    public class CRUDTester
    {
        private readonly IActivityDataHandler activity;
        private readonly ILikeDataHandler like;
        private readonly IUserDataHandler user;
        private readonly ICommentDataHandler comment;


        public CRUDTester(IActivityDataHandler a, ILikeDataHandler l, IUserDataHandler u, ICommentDataHandler c)
        {
            this.activity = a;
            this.like = l;
            this.user = u;
            this.comment = c;
        }

        public ppNominationActivitiesB GetActivity(int aid)
        {
            return activity.GetActivity(aid);
        }

        public List<ppNominationActivitiesB> GetActivitiesByPortal(int pid)
        {
            return activity.GetAllActivities(pid);
        }

        public List<ppLikes> GetLike(int nomid)
        {
            return like.GetLike(nomid);
        }

        public List<ppComments> GetComment(int nomid)
        {
            return comment.GetComments(nomid);
        }

        public User GetUser(int uid)
        {
            return user.GetUser(uid);
        }

        
    }
}
