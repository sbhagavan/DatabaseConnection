using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    public class User
    {
        [AutoIncrement]
        public int Id { get; set; }

        [Alias("USR_sFirstName")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleInitial { get; set; }
        public string Email { get; set; }
        public string LoginPassword { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool IsActive { get; set; }
        public int TotalPoints { get; set; }

        public int DepartmentId { get; set; }
        public int DotnetnukeId { get; set; }
        public bool UsedTheSystem { get; set; }
        public int JobPositionId { get; set; }
        public int LocationId { get; set; }
        public int ApproverId { get; set; }

        public int PortalId { get; set; }
        public int LeftForBonus { get; set; }
        public int UniqueId { get; set; }
        public string DisplayName { get; set; }
        public int SystemApprover { get; set; }
        public int Notes { get; set; }
        public string UserDefinedField1 { get; set; }
        public string UserDefinedField2 { get; set; }
        public string UserDefinedField3 { get; set; }

        public int DivisionId { get; set; }
        public bool OverrideUpload { get; set; }

        public int Primary { get; set; }
        public string LnoEmail { get; set; }
        public int VoteCount { get; set; }

    }
}
