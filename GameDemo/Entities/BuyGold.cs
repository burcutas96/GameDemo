using GameDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Entities
{
    internal class BuyGold : IGameSalesService
    {
        public void Sales(Member member, ICampaignsService campaign)
        {
            campaign.Delete();

            int goldPrice = 20;
            Console.Write("Ne kadar altın satın almak istiyosun?: ");
            int gold = int.Parse(Console.ReadLine());
            int amount = gold * goldPrice;
            if (member.Crash >= amount)
            {
                member.Crash -= amount;
                Console.WriteLine("Hesabınızda kalan nakit: "+ member.Crash);
            }
            else
            {
                Console.WriteLine("Bunun için yeterli nakitiniz yok!");
            }

            
        }
    }
}
