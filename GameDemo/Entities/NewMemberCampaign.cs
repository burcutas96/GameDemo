using GameDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Entities
{
    internal class NewMemberCampaign : ICampaignsService
    {

        public void Add()
        {
            Console.WriteLine("Yeni üyelere özel satışlarda %10 indirim!!!");
            
        }

        public void Delete()
        {
            Console.WriteLine("Yeni Üye Kampanyası silindi.");
        }

        public void Update()
        {
            Console.WriteLine("Yeni üye kampanyası %15 indirim ile güncellendi.");
        }
    }
}
