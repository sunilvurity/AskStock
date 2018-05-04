using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Bot.AskStock.Contracts
{
    public enum Intent
    {
        None,
        Intro,
        Appreciation,
        Greeting,
        Help,
        Icm_OnCall,
        IcM_GetIncident,
        IcM_QueryIncidents,
        Praise,
        QnA,
        VSTS_GetBugsForTag,
        VSTS_FindBugFromException,
        Xpert_GetQoS,
        Xpert_Dashboard,
        Xpert_GetReliability,
        Xpert_CorrelationVector,
        Xpert_GetExceptions,
    }
}
