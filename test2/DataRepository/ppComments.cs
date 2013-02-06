using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    public class ppComments
    {
        [AutoIncrement, PrimaryKey, Alias("CommentID")]
        public int Id { get; set; }

        public string CommentType { get; set; }

        public int USR_nID { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CommentText { get; set; }

        public int CommentTypeId { get; set; }
        public int PortalId { get; set; }
    }
}
