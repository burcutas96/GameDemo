using GameDemo.Entities;

namespace GameDemo.Abstract
{
    internal interface IGameSalesService
    {
        void Sales(Member member, ICampaignsService campaign);
    }
}
