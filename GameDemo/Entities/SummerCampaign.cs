using GameDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Entities
{
    internal class SummerCampaign : ICampaignsService
    {
        public void Add()
        {
            Console.WriteLine("15-22 Haziran tarihleri arasında yapılan satışlarda %50 indirim " );
        }

        public void Delete()
        {
            Console.WriteLine("Yaz Kampanyası silindi.");
        }

        public void Update()
        {
            Console.WriteLine("Yaz kampanyası %60 indirim ile güncellendi.");
        }
    }
}
