using GameDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concrete
{
    internal class CampaignManager : ICampaignService
    {

        public void Add(ICampaignsService campaignsService)
        {
            campaignsService.Add();
        }

        public void Delete(ICampaignsService campaignsService)
        {
            campaignsService.Delete();
        }

        public void Update(ICampaignsService campaignsService)
        {
            campaignsService.Update();
        }
    }
}
