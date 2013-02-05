using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    public class ppNominationActivitiesB
    {
       
        public int NOM_nID { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DeliveredOn { get; set; }

        public int RAT_nID { get; set; }
        public string ICO_sUrl { get; set; }
        public DateTime DisplayDate { get; set; }

        public int PortalId { get; set; }
        public bool Active { get; set; }
    }
}
