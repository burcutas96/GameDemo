using GameDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Entities
{
    internal class BuyMoney : IGameSalesService
    {
        public void Sales(Member member, ICampaignsService campaign)
        {
            campaign.Update();

            int moneyPrice = 5;
            Console.Write("Ne kadar para satın almak istiyosun?: ");
            int money = int.Parse(Console.ReadLine());
            int amount = money * moneyPrice;
            if (member.Crash >= amount)
            {
                member.Crash -= amount;
                Console.WriteLine("Hesabınızda kalan nakit: " + member.Crash);
            }
            else
            {
                Console.WriteLine("Bunun için yeterli nakitiniz yok!");
            }
        }
    }
}
