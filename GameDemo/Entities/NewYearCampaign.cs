using GameDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Entities
{
    internal class NewYearCampaign : ICampaignsService
    {
        public void Add()
        {
            Console.WriteLine("Yeni yıla özel tüm satışlarda %80'e varan indirim");
        }

        public void Delete()
        {
            Console.WriteLine("Yeni Yıl Kapmanyası silindi. ");
        }

        public void Update()
        {
            Console.WriteLine("Yeni Yıl Kampanyası güncellendi");
        }
    }
}
