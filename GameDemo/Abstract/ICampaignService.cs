using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Abstract
{
    internal interface ICampaignService
    {
        void Add(ICampaignsService campaignsService);
        void Delete(ICampaignsService campaignsService);
        void Update(ICampaignsService campaignsService);
    }
}
