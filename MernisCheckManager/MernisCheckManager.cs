using CheckPersonWithMernis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MernisCheckManager
{
    public class MernisCheckManager
    {
        

        public static  bool CheckPerson(string firstname, string lastName, long identityNumber,int birthdayYear)
        {
            var client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            var result = client.TCKimlikNoDogrulaAsync(identityNumber, firstname, lastName, birthdayYear).Result.Body.TCKimlikNoDogrulaResult;
            return result;
        }
    }
}
