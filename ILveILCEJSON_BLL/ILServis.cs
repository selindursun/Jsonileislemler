using ILveILCEJSON_ENTITYMODELS.Classlar;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ILveILCEJSON_BLL
{
    public class ILServis
    {
        private string JSonString = string.Empty;//field
        public ILServis()
        {
            VeriKaynaginaBaglan();
        }
        private void VeriKaynaginaBaglan()
        {
            using (WebClient istemci = new WebClient())
            {
                
                byte[] data = istemci.DownloadData(@"C:\Users\103SABAH_SELİN\Source\Repos\Jsonileislemler\belediyeler.json");
                //json dosyasında ş ç ü gibi harfler çevrilirken bozulma yaşanabiliyor. biz encoding utf 8 kullanırsak
                //bütün dillere göre çözüm sunar.
                JSonString = Encoding.UTF8.GetString(data);
                
            }
        }
        public List<IL> IlleriGetir()
        {
            return JsonConvert.DeserializeObject<List<IL>>(JSonString);
        }

    }
}
