using GameDemo.Abstract;
using GameDemo.Entities;
using MernisServiceReference1;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concrete
{
    internal class MemberCheckManager : IMemberCheckService
    {
        public bool MemberCheckIfReal(Member member)
        {
            var locale = new CultureInfo("tr-TR", false);
            var svc = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            {
                var cmd = svc.TCKimlikNoDogrulaAsync(Convert.ToInt64(member.NationalityId), member.FirstName, member.LastName, member.DateOfBirth.Year);
                return cmd.Result.Body.TCKimlikNoDogrulaResult;
            };
        }
    }
}
